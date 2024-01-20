using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp_Figures_50115
{
    public partial class form_Main : Form
    {
        private int _x = 250;
        private int _y = 170;
        private int _i = 0;
        private Graphics _gr;
        private int _index;
        private Color _colorPen = Color.Black;
        private Color _colorBrush = Color.Black;

        public form_Main()
        {
            InitializeComponent();
            _gr = pictureBox.CreateGraphics();
            listBox_Primitives.SelectedIndex = 0;
        }

        private void listBox_Primitives_SelectedIndexChanged(object sender, EventArgs e)
        {
            _index = listBox_Primitives.SelectedIndex; 
        }

        private void button_ColorPen_Click(object sender, EventArgs e)
        {
            if (colorDialog_Pen.ShowDialog() == DialogResult.OK)
            {
                _colorPen = colorDialog_Pen.Color;
                pictureBox.Invalidate();
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            Point p = new Point(e.X, e.Y);
            this._x = p.X;
            this._y = p.Y;
            pictureBox.Invalidate();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            Pen pn = new Pen(_colorPen, 8);
            _gr = e.Graphics;
            SolidBrush sb = new SolidBrush(_colorBrush);
            Font f = new Font("Courier New", 18, FontStyle.Bold);
            string str = "x = " + _x.ToString() + " " + "y = " + _y.ToString();
            string my_str = "50115АС";
            switch(_index)
            {
                case 0:
                    _gr.DrawEllipse(pn, _x - 100, _y - 100, 200, 200);
                    _gr.FillEllipse(sb, _x - 100, _y - 100, 200, 200);
                    break;
                case 1:
                    _gr.DrawRectangle(pn, _x - 100, _y - 100, 200, 200);
                    _gr.FillRectangle(sb, _x - 100, _y - 100, 200, 200);
                    break;
                case 2:
                    _gr.DrawPie(pn, _x - 100, _y - 100, 200, 200, 0, 120);
                    _gr.FillPie(sb, _x - 100, _y - 100, 200, 200, 0, 120);
                    break;
                case 3:
                    _gr.DrawLine(pn, _x - 50, _y - 50, 400, 250);
                    break;
                case 4:
                    _gr.DrawString(str, f, sb, _x, _y);
                    break;
                case 5:
                    _gr.DrawArc(pn, _x - 100, _y - 100, 200, 200, 0, 120);
                    break;
                case 6:
                    _gr.DrawString(my_str, f, sb, _x, _y);
                    break;
            }
            _i = _i + 5;
        }

        private void button_ColorBrush_Click(object sender, EventArgs e)
        {
            if (colorDialog_Brush.ShowDialog() == DialogResult.OK)
            {
                _colorBrush = colorDialog_Brush.Color;
                pictureBox.Invalidate();
            }
        }

        private void button_Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button_i_Click(object sender, EventArgs e)
        {
            _i = -1;
        }
    }
}
