using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpecialButton
{
    public partial class SpecialButton : Button
    {
        public SpecialButton()
        {
            InitializeComponent();

            SetNormalValues();
            
        }

        private void SetNormalValues()
        {
            this.Font = new Font("Verdana", 8F, FontStyle.Bold);
            this.BackColor = Color.Gray;
            this.ForeColor = Color.White;
            this.Margin = new Padding(4, 1, 1, 0);
            this.Padding = new Padding(4);
            this.MinimumSize = new Size(150, 35);
            this.Cursor = Cursors.Arrow;
        }

        private void SetValuesOnFocus()
        {
            this.Font = new Font("Verdana", 10F, FontStyle.Bold);

            this.BackColor = Color.Green;
            this.ForeColor = Color.White;


            this.Cursor = Cursors.Hand;

        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        protected override void OnMouseHover(EventArgs e)
        {
            base.OnMouseHover(e);
            SetValuesOnFocus();
        }

        protected override void OnMouseLeave(EventArgs e)
        {
            base.OnMouseLeave(e);
            SetNormalValues();
        }
    }
}
