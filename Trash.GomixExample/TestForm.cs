using System;
using System.Drawing;
using System.Windows.Forms;

namespace Trash.GomixExample
{
    using GoMix;

    public partial class TestForm : Form
    {
        public TestForm()
        {
            InitializeComponent();
        }

        private void byteUnitTextBox1_TextChanged(object sender, EventArgs e)
        {
            if (sender is ByteUnitTextBox)
            {
                var trashBox = (ByteUnitTextBox)sender;
                var max = trashBox.MaxLength;
                var len = trashBox.ByteLength;
                Text = $"{Name} - {len} Byte";
                var p = 1.0 * len / max;
                var ratio = (int)Math.Floor(p * 254);
                var color = Color.FromArgb(ratio, 0, 0);
                trashBox.ForeColor = color;
            }
        }
    }
}
