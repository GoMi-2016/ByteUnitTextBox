namespace Trash.GoMix
{
    /// <summary>
    /// ウィンドウメッセージリスト
    /// </summary>
    public class WindowMessages
    {
        // TODO: 対応するメッセージが存在しない場合追加して下さい。

        #region "Messages"

        /// <summary>特に意味はありません。</summary>
        public const int WM_NULL = 0x00;
        /// <summary>ウインドウが作成されていることを示します。</summary>
        public const int WM_CREATE = 0x01;
        /// <summary>ウインドウが破棄されようとしていることを示します。</summary>
        public const int WM_DESTROY = 0x02;
        /// <summary>ウインドウの位置が変更されたことを示します。</summary>
        public const int WM_MOVE = 0x03;
        /// <summary>ウインドウのサイズが変更されていることを示します。</summary>
        public const int WM_SIZE = 0x05;
        /// <summary>アクティブ状態が変更されていることを示します。</summary>
        public const int WM_ACTIVATE = 0x06;
        /// <summary>ウインドウがキーボード・フォーカスを取得したことを示します。</summary>
        public const int WM_SETFOCUS = 0x07;
        /// <summary>ウインドウがキーボード・フォーカスを失っていることを示します。</summary>
        public const int WM_KILLFOCUS = 0x08;
        /// <summary>ウインドウの有効または無効の状態が変更されていることを示します。</summary>
        public const int WM_ENABLE = 0x0A;
        /// <summary>ウインドウ内の再描画を許可または禁止します。</summary>
        public const int WM_SETREDRAW = 0x0B;
        /// <summary>ウインドウのテキストを設定します。</summary>
        public const int WM_SETTEXT = 0x0C;
        /// <summary>ウインドウに対応するテキストを取得します。</summary>
        public const int WM_GETTEXT = 0x0D;
        /// <summary>ウインドウに関連付けられているテキストの長さを取得します。</summary>
        public const int WM_GETTEXTLENGTH = 0x0E;
        /// <summary>ウインドウのクライアント領域を描画する必要があることを示します。</summary>
        public const int WM_PAINT = 0x0F;
        /// <summary>コントロール・メニューの[クローズ]コマンドが選ばれました。</summary>
        public const int WM_CLOSE = 0x10;
        /// <summary>Windowsセッションを終了するよう要求します。</summary>
        public const int WM_QUERYENDSESSION = 0x11;
        /// <summary>アプリケーションを強制終了するよう要求します。</summary>
        public const int WM_QUIT = 0x12;
        /// <summary>アイコン化ウインドウを復元するよう要求します。</summary>
        public const int WM_QUERYOPEN = 0x13;
        /// <summary>ウインドウの背景を消去する必要があることを示します。</summary>
        public const int WM_ERASEBKGND = 0x14;
        /// <summary>システム・カラーの値が変更されたことを示します。</summary>
        public const int WM_SYSCOLORCHANGE = 0x15;
        /// <summary>Windowsセッションが終了することを示します。</summary>
        public const int WM_ENDSESSION = 0x16;
        /// <summary></summary>
        public const int WM_SYSTEMERROR = 0x17;
        /// <summary>ウインドウの表示または非表示の状態が変更されようとしていることを示します。</summary>
        public const int WM_SHOWWINDOW = 0x18;
        /// <summary>子コントロールが描画される直前であることを示します。</summary>
        public const int WM_CTLCOLOR = 0x19;
        /// <summary>WIN.INIが変更されたことをアプリケーションに通知します。</summary>
        public const int WM_WININICHANGE = 0x1A;
        /// <summary>Windowsの設定が変更されたことをアプリケーションに通知します。</summary>
        public const int WM_SETTINGCHANGE = 0x1A;
        /// <summary>デバイス モードの設定が変更されたことを示します。</summary>
        public const int WM_DEVMODECHANGE = 0x1B;
        /// <summary>新しいタスクがアクティブになるタイミングをアプリケーションに通知します。</summary>
        public const int WM_ACTIVATEAPP = 0x1C;
        /// <summary>システム時刻が設定されたことを示します。</summary>
        public const int WM_FONTCHANGE = 0x1D;
        /// <summary>システム時刻が設定されたことを示します。</summary>
        public const int WM_TIMECHANGE = 0x1E;
        /// <summary>内部モードをキャンセルするようウインドウに通知します。</summary>
        public const int WM_CANCELMODE = 0x1F;
        /// <summary>マウス カーソルの形状を設定するようウインドウに促します。</summary>
        public const int WM_SETCURSOR = 0x20;
        /// <summary>非アクティブ ウインドウ内でマウスがクリックされたことを示します。</summary>
        public const int WM_MOUSEACTIVATE = 0x21;
        /// <summary>子ウインドウにアクティブであることを通知します。</summary>
        public const int WM_CHILDACTIVATE = 0x22;
        /// <summary>CBTメッセージを区切ります。</summary>
        public const int WM_QUEUESYNC = 0x23;
        /// <summary>アイコン表示時および最大表示時のサイズ情報を取得します。</summary>
        public const int WM_GETMINMAXINFO = 0x24;
        /// <summary>アイコンが描画されようとしています。</summary>
        public const int WM_PAINTICON = 0x26;
        /// <summary>アイコンの背景を塗りつぶすようアイコン化ウインドウに通知します。</summary>
        public const int WM_ICONERASEBKGND = 0x27;
        /// <summary>フォーカスを別のダイアログ ボックス コントロールに設定します。</summary>
        public const int WM_NEXTDLGCTL = 0x28;
        /// <summary>印刷ジョブが追加または削除されたことを示します。(XP 以降ではサポートされません)</summary>
        public const int WM_SPOOLERSTATUS = 0x2A;
        /// <summary>オーナー描画コントロールまたはオーナー描画メニューを再描画する必要があることを示します。</summary>
        public const int WM_DRAWITEM = 0x2B;
        /// <summary>オーナー描画のコントロールまたは項目の寸法を要求します。</summary>
        public const int WM_MEASUREITEM = 0x2C;
        /// <summary>ほかのオーナー描画項目またはオーナー描画コントロールに代わったことを示します。</summary>
        public const int WM_DELETEITEM = 0x2D;
        /// <summary>リスト ボックスのキーストロークをそのオーナー ウインドウに提供します。</summary>
        public const int WM_VKEYTOITEM = 0x2E;
        /// <summary>リスト ボックスのキーストロークをそのオーナー ウインドウに提供します。</summary>
        public const int WM_CHARTOITEM = 0x2F;

        /// <summary>コントロールで使われるフォントを設定します。</summary>
        public const int WM_SETFONT = 0x30;
        /// <summary>コントロールで使われているフォントを取得します。</summary>
        public const int WM_GETFONT = 0x31;
        /// <summary>ウインドウにホット キーを関連付けます。</summary>
        public const int WM_SETHOTKEY = 0x32;
        /// <summary>ウインドウのホット キーの仮想キー コードを取得します。</summary>
        public const int WM_GETHOTKEY = 0x33;
        /// <summary>アイコン化ウインドウに対してマウス カーソルのハンドルを要求します。</summary>
        public const int WM_QUERYDRAGICON = 0x37;
        /// <summary>コンボ ボックスまたはリスト ボックスの項目位置を判断します。</summary>
        public const int WM_COMPAREITEM = 0x39;
        /// <summary>メモリ不足状態であることを示します。</summary>
        public const int WM_COMPACTING = 0x41;
        /// <summary>ウインドウに新しいサイズまたは位置を通知します。</summary>
        public const int WM_WINDOWPOSCHANGING = 0x46;
        /// <summary>ウインドウにサイズまたは位置の変更を通知します。</summary>
        public const int WM_WINDOWPOSCHANGED = 0x47;
        /// <summary>システムが中断モードに入っていることを示します。</summary>
        public const int WM_POWER = 0x48;
        /// <summary>ほかのアプリケーションにデータを渡します。</summary>
        public const int WM_COPYDATA = 0x4A;
        /// <summary>ユーザーがジャーナル モードをキャンセルしました。</summary>
        public const int WM_CANCELJOURNAL = 0x4B;
        /// <summary></summary>
        public const int WM_NOTIFY = 0x4E;
        /// <summary></summary>
        public const int WM_INPUTLANGCHANGEREQUEST = 0x50;
        /// <summary></summary>
        public const int WM_INPUTLANGCHANGE = 0x51;
        /// <summary></summary>
        public const int WM_TCARD = 0x52;
        /// <summary></summary>
        public const int WM_HELP = 0x53;
        /// <summary>ユーザがログオン/ログオフしたことを示します。</summary>
        public const int WM_USERCHANGED = 0x54;
        /// <summary></summary>
        public const int WM_NOTIFYFORMAT = 0x55;
        /// <summary></summary>
        public const int WM_CONTEXTMENU = 0x7B;
        /// <summary>SetWindowLong() によってウインドウのスタイルが変更されようとしています。</summary>
        public const int WM_STYLECHANGING = 0x7C;
        /// <summary>SetWindowLong() によってウインドウのスタイルが変更されました。</summary>
        public const int WM_STYLECHANGED = 0x7D;
        /// <summary>ディスプレイの解像度が変更されたことを示します。</summary>
        public const int WM_DISPLAYCHANGE = 0x7E;
        /// <summary></summary>
        public const int WM_GETICON = 0x7F;
        /// <summary></summary>
        public const int WM_SETICON = 0x80;

        /// <summary>ウインドウの非クライアント領域が作成されていることを示します。</summary>
        public const int WM_NCCREATE = 0x81;
        /// <summary>ウインドウの非クライアント領域が破棄されていることを示します。</summary>
        public const int WM_NCDESTROY = 0x82;
        /// <summary>ウインドウのクライアント領域のサイズを計算します。</summary>
        public const int WM_NCCALCSIZE = 0x83;
        /// <summary>マウス カーソルが移動したことを示します。</summary>
        public const int WM_NCHITTEST = 0x84;
        /// <summary>ウインドウの枠を描画する必要があることを示します。</summary>
        public const int WM_NCPAINT = 0x85;
        /// <summary>非クライアント領域のアクティブ状態を変更します。</summary>
        public const int WM_NCACTIVATE = 0x86;
        /// <summary>ダイアログ プロシージャがコントロール入力を処理できるようにします。</summary>
        public const int WM_GETDLGCODE = 0x87;
        /// <summary>非クライアント領域でマウス カーソルが移動したことを示します。</summary>
        public const int WM_NCMOUSEMOVE = 0xA0;
        /// <summary>非クライアント領域でマウスの左ボタンが押されたことを示します。</summary>
        public const int WM_NCLBUTTONDOWN = 0xA1;
        /// <summary>非クライアント領域でマウスの左ボタンが離されたことを示します。</summary>
        public const int WM_NCLBUTTONUP = 0xA2;
        /// <summary>非クライアント領域でマウスの左ボタンをダブルクリックしたことを示します。</summary>
        public const int WM_NCLBUTTONDBLCLK = 0xA3;
        /// <summary>非クライアント領域でマウスの右ボタンが押されたことを示します。</summary>
        public const int WM_NCRBUTTONDOWN = 0xA4;
        /// <summary>非クライアント領域でマウスの右ボタンが離されたことを示します。</summary>
        public const int WM_NCRBUTTONUP = 0xA5;
        /// <summary>非クライアント領域でマウスの右ボタンをダブルクリックしたことを示します。</summary>
        public const int WM_NCRBUTTONDBLCLK = 0xA6;
        /// <summary>非クライアント領域でマウスの中央ボタンが押されたことを示します。</summary>
        public const int WM_NCMBUTTONDOWN = 0xA7;
        /// <summary>非クライアント領域でマウスの中央ボタンが離されたことを示します。</summary>
        public const int WM_NCMBUTTONUP = 0xA8;
        /// <summary>非クライアント領域でマウスの中央ボタンをダブルクリックしたことを示します。</summary>
        public const int WM_NCMBUTTONDBLCLK = 0xA9;

        /// <summary></summary>
        public const int WM_KEYFIRST = 0x100;
        /// <summary>非システム キーが押されたことを示します。</summary>
        public const int WM_KEYDOWN = 0x100;
        /// <summary>非システム キーが離されたことを示します。</summary>
        public const int WM_KEYUP = 0x101;
        /// <summary>ユーザーが文字キーを押したことを示します。</summary>
        public const int WM_CHAR = 0x102;
        /// <summary>ユーザーがデッド キーを押したことを示します。</summary>
        public const int WM_DEADCHAR = 0x103;
        /// <summary>Alt+任意のキーが押されたことを示します。</summary>
        public const int WM_SYSKEYDOWN = 0x104;
        /// <summary>Alt+任意のキーが離されたことを示します。</summary>
        public const int WM_SYSKEYUP = 0x105;
        /// <summary>コントロール メニュー キーが押されたことを示します。</summary>
        public const int WM_SYSCHAR = 0x106;
        /// <summary>システム デッド キーが押されたを示します。</summary>
        public const int WM_SYSDEADCHAR = 0x107;
        /// <summary></summary>
        public const int WM_KEYLAST = 0x108;

        /// <summary></summary>
        public const int WM_IME_STARTCOMPOSITION = 0x10D;
        /// <summary></summary>
        public const int WM_IME_ENDCOMPOSITION = 0x10E;
        /// <summary></summary>
        public const int WM_IME_COMPOSITION = 0x10F;
        /// <summary></summary>
        public const int WM_IME_KEYLAST = 0x10F;

        /// <summary></summary>
        public const int WM_INITDIALOG = 0x110;
        /// <summary></summary>
        public const int WM_COMMAND = 0x111;
        /// <summary></summary>
        public const int WM_SYSCOMMAND = 0x112;
        /// <summary></summary>
        public const int WM_TIMER = 0x113;
        /// <summary></summary>
        public const int WM_HSCROLL = 0x114;
        /// <summary></summary>
        public const int WM_VSCROLL = 0x115;
        /// <summary></summary>
        public const int WM_INITMENU = 0x116;
        /// <summary></summary>
        public const int WM_INITMENUPOPUP = 0x117;
        /// <summary></summary>
        public const int WM_MENUSELECT = 0x11F;
        /// <summary></summary>
        public const int WM_MENUCHAR = 0x120;
        /// <summary></summary>
        public const int WM_ENTERIDLE = 0x121;

        /// <summary></summary>
        public const int WM_CTLCOLORMSGBOX = 0x132;
        /// <summary></summary>
        public const int WM_CTLCOLOREDIT = 0x133;
        /// <summary></summary>
        public const int WM_CTLCOLORLISTBOX = 0x134;
        /// <summary></summary>
        public const int WM_CTLCOLORBTN = 0x135;
        /// <summary></summary>
        public const int WM_CTLCOLORDLG = 0x136;
        /// <summary></summary>
        public const int WM_CTLCOLORSCROLLBAR = 0x137;
        /// <summary></summary>
        public const int WM_CTLCOLORSTATIC = 0x138;

        /// <summary></summary>
        public const int WM_MOUSEFIRST = 0x200;
        /// <summary></summary>
        public const int WM_MOUSEMOVE = 0x200;
        /// <summary></summary>
        public const int WM_LBUTTONDOWN = 0x201;
        /// <summary></summary>
        public const int WM_LBUTTONUP = 0x202;
        /// <summary></summary>
        public const int WM_LBUTTONDBLCLK = 0x203;
        /// <summary></summary>
        public const int WM_RBUTTONDOWN = 0x204;
        /// <summary></summary>
        public const int WM_RBUTTONUP = 0x205;
        /// <summary></summary>
        public const int WM_RBUTTONDBLCLK = 0x206;
        /// <summary></summary>
        public const int WM_MBUTTONDOWN = 0x207;
        /// <summary></summary>
        public const int WM_MBUTTONUP = 0x208;
        /// <summary></summary>
        public const int WM_MBUTTONDBLCLK = 0x209;
        /// <summary></summary>
        public const int WM_MOUSEWHEEL = 0x20A;
        /// <summary></summary>
        public const int WM_MOUSEHWHEEL = 0x20E;

        /// <summary></summary>
        public const int WM_PARENTNOTIFY = 0x210;
        /// <summary></summary>
        public const int WM_ENTERMENULOOP = 0x211;
        /// <summary></summary>
        public const int WM_EXITMENULOOP = 0x212;
        /// <summary></summary>
        public const int WM_NEXTMENU = 0x213;
        /// <summary></summary>
        public const int WM_SIZING = 0x214;
        /// <summary></summary>
        public const int WM_CAPTURECHANGED = 0x215;
        /// <summary></summary>
        public const int WM_MOVING = 0x216;
        /// <summary></summary>
        public const int WM_POWERBROADCAST = 0x218;
        /// <summary></summary>
        public const int WM_DEVICECHANGE = 0x219;

        /// <summary>子ウインドウを作成するようMDIクライアントに促します。</summary>
        public const int WM_MDICREATE = 0x220;
        /// <summary>MDI子ウインドウをクローズします。</summary>
        public const int WM_MDIDESTROY = 0x221;
        /// <summary>MDI子ウインドウをアクティブ化します。</summary>
        public const int WM_MDIACTIVATE = 0x222;
        /// <summary>子ウインドウを復元するようMDIクライアントに促します。</summary>
        public const int WM_MDIRESTORE = 0x223;
        /// <summary>次のMDI子ウインドウをアクティブ化します。</summary>
        public const int WM_MDINEXT = 0x224;
        /// <summary>MDI子ウインドウを最大化します。</summary>
        public const int WM_MDIMAXIMIZE = 0x225;
        /// <summary>MDI子ウインドウを並べて整列させます。</summary>
        public const int WM_MDITILE = 0x226;
        /// <summary>MDI子ウインドウを重ねて整列させます。</summary>
        public const int WM_MDICASCADE = 0x227;
        /// <summary>アイコン化されたMDI子ウインドウを整列します。</summary>
        public const int WM_MDIICONARRANGE = 0x228;
        /// <summary>アクティブなMDI子ウインドウに関するデータを取得します。</summary>
        public const int WM_MDIGETACTIVE = 0x229;
        /// <summary>MDIフレーム ウインドウのメニューを置き換えます。</summary>
        public const int WM_MDISETMENU = 0x230;
        /// <summary>ウインドウのサイズ変更/移動が行われる前に通知されます。</summary>
        public const int WM_ENTERSIZEMOVE = 0x231;
        /// <summary>ウインドウのサイズ変更/移動が行われた後に通知されます。</summary>
        public const int WM_EXITSIZEMOVE = 0x232;
        /// <summary>ファイルがドロップされたことを示します。</summary>
        public const int WM_DROPFILES = 0x233;
        /// <summary>MDIフレーム ウインドウのメニューを最新表示します。</summary>
        public const int WM_MDIREFRESHMENU = 0x234;

        /// <summary></summary>
        public const int WM_IME_SETCONTEXT = 0x281;
        /// <summary></summary>
        public const int WM_IME_NOTIFY = 0x282;
        /// <summary></summary>
        public const int WM_IME_CONTROL = 0x283;
        /// <summary></summary>
        public const int WM_IME_COMPOSITIONFULL = 0x284;
        /// <summary></summary>
        public const int WM_IME_SELECT = 0x285;
        /// <summary></summary>
        public const int WM_IME_CHAR = 0x286;
        /// <summary></summary>
        public const int WM_IME_KEYDOWN = 0x290;
        /// <summary></summary>
        public const int WM_IME_KEYUP = 0x291;

        /// <summary>マウスがウインドウのクライアントエリア上でホバリングしてから、TrackMouseEvent 関数への呼び出しであらかじめ指定された時間が経過しました。</summary>
        public const int WM_MOUSEHOVER = 0x2A1;
        /// <summary>マウスが、TrackMouseEvent の前回の呼び出しで指定されている時間のあいだカーソルがウインドウの非クライアント領域から出ていました。</summary>
        public const int WM_NCMOUSELEAVE = 0x2A2;
        /// <summary>マウスが、TrackMouseEvent 関数への呼び出しであらかじめ指定されたウインドウのクライアントエリアを離れました。</summary>
        public const int WM_MOUSELEAVE = 0x2A3;

        /// <summary>選択項目を削除し､ クリップボードにコピーします。</summary>
        public const int WM_CUT = 0x300;
        /// <summary>クリップボードに選択項目をコピーします。</summary>
        public const int WM_COPY = 0x301;
        /// <summary>クリップボード データをエディット コントロールに挿入します。</summary>
        public const int WM_PASTE = 0x302;
        /// <summary>エディット コントロールをクリアします。</summary>
        public const int WM_CLEAR = 0x303;
        /// <summary>エディット コントロール内での直前の操作を取り消します。</summary>
        public const int WM_UNDO = 0x304;

        /// <summary>クリップボード データをレンダするようオーナーに通知します。</summary>
        public const int WM_RENDERFORMAT = 0x305;
        /// <summary>すべてのクリップボード形式をレンダするようオーナーに通知します。</summary>
        public const int WM_RENDERALLFORMATS = 0x306;
        /// <summary>クリップボードが空になったことをオーナーに通知します。</summary>
        public const int WM_DESTROYCLIPBOARD = 0x307;
        /// <summary>クリップボードの内容が変更されたことを示します。</summary>
        public const int WM_DRAWCLIPBOARD = 0x308;
        /// <summary>クリップボードの内容を表示するようオーナーに促します。</summary>
        public const int WM_PAINTCLIPBOARD = 0x309;
        /// <summary>クリップボードの内容をスクロールするようオーナーに促します。</summary>
        public const int WM_VSCROLLCLIPBOARD = 0x30A;
        /// <summary>クリップボードのサイズが変更されていることを示します。</summary>
        public const int WM_SIZECLIPBOARD = 0x30B;
        /// <summary>新しいタスクがアクティブになるタイミングをアプリケーションに通知します。</summary>
        public const int WM_ASKCBFORMATNAME = 0x30C;
        /// <summary>クリップボード ビューアのチェインからの除去を通知します。</summary>
        public const int WM_CHANGECBCHAIN = 0x30D;
        /// <summary>クリップボードの内容をスクロールするようオーナーに促します。</summary>
        public const int WM_HSCROLLCLIPBOARD = 0x30E;
        /// <summary>ウインドウがその論理パレットを実現できるようにします。</summary>
        public const int WM_QUERYNEWPALETTE = 0x30F;
        /// <summary>パレットが変更されていることを各ウインドウに通知します。</summary>
        public const int WM_PALETTEISCHANGING = 0x310;
        /// <summary>フォーカス ウインドウがそのパレットを実現したことを示します。</summary>
        public const int WM_PALETTECHANGED = 0x311;

        /// <summary>ホット キーが検出されています。</summary>
        public const int WM_HOTKEY = 0x312;
        /// <summary></summary>
        public const int WM_PRINT = 0x317;
        /// <summary></summary>
        public const int WM_PRINTCLIENT = 0x318;

        /// <summary></summary>
        public const int WM_HANDHELDFIRST = 0x358;
        /// <summary></summary>
        public const int WM_HANDHELDLAST = 0x35F;
        /// <summary></summary>
        public const int WM_PENWINFIRST = 0x380;
        /// <summary></summary>
        public const int WM_PENWINLAST = 0x38F;
        /// <summary></summary>
        public const int WM_COALESCE_FIRST = 0x390;
        /// <summary></summary>
        public const int WM_COALESCE_LAST = 0x39F;
        /// <summary></summary>
        public const int WM_DDE_FIRST = 0x3E0;
        /// <summary>DDE対話を開始します。</summary>
        public const int WM_DDE_INITIATE = 0x3E0;
        /// <summary>DDE対話を終了します。</summary>
        public const int WM_DDE_TERMINATE = 0x3E1;
        /// <summary>DDEデータ変更の更新を要求します。</summary>
        public const int WM_DDE_ADVISE = 0x3E2;
        /// <summary>DDEデータの更新要求を停止させます。</summary>
        public const int WM_DDE_UNADVISE = 0x3E3;
        /// <summary>DDEメッセージに対して受領通知をします。</summary>
        public const int WM_DDE_ACK = 0x3E4;
        /// <summary>データををDDEクライアントに送ります。</summary>
        public const int WM_DDE_DATA = 0x3E5;
        /// <summary>DDEサーバーからデータを要求します。</summary>
        public const int WM_DDE_REQUEST = 0x3E6;
        /// <summary>未要求のデータをサーバーに送ります。</summary>
        public const int WM_DDE_POKE = 0x3E7;
        /// <summary>文字列をDDEサーバーに送ります。</summary>
        public const int WM_DDE_EXECUTE = 0x3E8;

        /// <summary>メッセージ値の範囲を示します。 0x0000..WM_USER-1 はシステム予約です。WM_USER..WM_APP-1 は Windows で利用されます。</summary>
        public const int WM_USER = 0x400;
        /// <summary>WM_APP..WM_APP + 0x3FFF はアプリケーションで自由に定義できます。</summary>
        public const int WM_APP = 0x8000;

        #endregion
    }
}