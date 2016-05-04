using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Forms;

namespace Trash.GoMix
{
    /// <summary>
    /// テキストボックスの字数カウントをバイト毎に変更
    /// </summary>
    [DesignerCategory("code")]
    public sealed class ByteUnitTextBox : TextBox
    {
        /// <summary>
        /// 既定の最大バイト数
        /// </summary>
        public const int DEFAULT_MAX_LENGTH = 0xFFFF;

        /// <summary>
        /// 既定のエンコーダー
        /// </summary>
        public readonly Encoding DEAULT_ENCODER = Encoding.GetEncoding("Shift_JIS");
        
        private Encoding encode;

        private int maxLength;
        
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ByteUnitTextBox()
        {
            MaxLength = DEFAULT_MAX_LENGTH;
        }
        
        /// <summary>
        /// Windows メッセージを処理します。
        /// </summary>
        /// <param name="m"></param>
        protected sealed override void WndProc(ref Message m)
        {
            var msg = m.Msg;

            if (msg.Equals(WindowMessages.WM_KEYDOWN))
            {
                var wparam = (Keys)m.WParam;
                var keyEventArgs = new KeyEventArgs(wparam);
                KeyDown(keyEventArgs);
                if (keyEventArgs.Handled) return;
            }
            else if (msg.Equals(WindowMessages.WM_CHAR))
            {
                var wparam = (char)m.WParam;
                var keyPressEventArgs = new KeyPressEventArgs(wparam);
                KeyPress(keyPressEventArgs);
                if (keyPressEventArgs.Handled) return;
            }
            else if (msg.Equals(WindowMessages.WM_PASTE))
            {
                var args = Clipboard.GetText();
                Paste(args);
                return;
            }

            base.WndProc(ref m);
        }

        /// <summary>
        /// キーボードのキーが押された場合に発生するイベントです。
        /// </summary>
        private new void KeyDown(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// キーボードのキーが押された場合に発生するイベントです。
        /// </summary>
        private new void KeyPress(KeyPressEventArgs e)
        {
            // HACK: ここ凄く適当です。修正して下さい

            var @char = e.KeyChar;

            if (@char > 0 && @char < 27)
            {
                var keys = (Keys)e.KeyChar + '@';

                var valid = new Keys[] { Keys.C, Keys.V, Keys.X, Keys.Z };

                if (ModifierKeys.Equals(Keys.Control))
                {
                    if (keys == Keys.A)
                    {
                        SelectAll();
                        e.Handled = true;
                        return;
                    }
                    else if (0 <= Array.IndexOf(valid, keys))
                    {
                        return;
                    }
                }
                else if (keys == Keys.H)
                {
                    return;
                }
            }

            var input = Encoder.GetByteCount(new char[] { e.KeyChar }, 0, 1);
            var select = Encoder.GetByteCount(SelectedText);
            var allow = ByteLength + input - select;

            if (allow > MaxLength)
            {
                e.Handled = true;
            }
        }

        private new void Paste(string text)
        {
            if (string.IsNullOrEmpty(text)) return;
            var chars = Encoder.GetByteCount(SelectedText);
            var allow = MaxLength - (ByteLength - chars);
            if (allow <= 0) return;
            SelectedText = CutToMultiByteLength(text, allow);
        }

        private string CutToMultiByteLength(string @in, int len)
        {
            var count = 0;
            var chars = new List<char>();
            foreach (char @char in @in)
            {
                var bytesCount = Encoder.GetByteCount(new char[] { @char }, 0, 1);
                if ((count += bytesCount) > len) break;
                else chars.Add(@char);
            }
            return string.Concat(chars);
        }
        
        /// <summary>
        /// ユーザーがテキスト ボックス コントロールに入力または貼り付けできる最大バイト数を取得または設定します。
        /// </summary>
        [Category("動作")]
        [DefaultValue(DEFAULT_MAX_LENGTH)]
        [Description("エディットコントロールに入力できる最大バイト数を指定します。")]
        public override int MaxLength
        {
            get
            {
                return maxLength;
            }
            set
            {
                if (maxLength != value)
                {
                    maxLength = value;

                    // 対応しきれていない制御文字の為に
                    // TextBoxBase側の字数制限を有効にする
                    // (Unicode制御文字には非対応)
                    if (base.MaxLength != value)
                    {
                        base.MaxLength = value;
                    }
                }
            }
        }

        /// <summary>
        /// コントロールに設定されたテキストのバイト数を取得します。
        /// </summary>
        [Browsable(false)]
        public int ByteLength
        {
            get
            {
                return Encoder.GetByteCount(Text);
            }
        }

        /// <summary>
        /// 文字エンコーディングを表します。
        /// </summary>
        [Browsable(false)]
        public Encoding Encoder
        {
            get
            {
                return encode ?? DEAULT_ENCODER;
            }
            set
            {
                encode = value;
            }
        }
    }
}
