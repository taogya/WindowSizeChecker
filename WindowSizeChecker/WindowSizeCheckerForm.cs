using System;
using System.Windows.Forms;

namespace WindowSizeChecker
{
    public partial class WindowSizeCheckerForm : Form
    {
        public WindowSizeCheckerForm()
        {
            InitializeComponent();
            Console.WriteLine($"Width={Width}, Height={Height}");
            Resize += WindowSizeCheckerForm_Resize;
            //TransparencyKey = BackColor;
            Opacity = 0.7;
        }

        private void WindowSizeCheckerForm_Resize(object sender, System.EventArgs e)
        {
            Console.WriteLine($"Width={Width}, Height={Height}");
        }
    }
}