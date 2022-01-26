using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RectangleFormula.Views;
using RectangleFormula.Presenters;

namespace RectangleFormula
{
    public partial class Form1 : Form,IRectangle
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string PanjangText
        {
            get
            {
                return txtPanjang.Text;
            }
            set
            {
                txtPanjang.Text = value;
            }
        }

        public string LebarText
        {
            get
            {
                return txtLebar.Text;

            }
            set
            {
                txtLebar.Text = value;
            }
        }

        public string AreaText
        {
            get
            {
                return lblArea.Text;
            }
            set
            {
                lblArea.Text = value + " cm";
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            RectanglePresenter presenter = new RectanglePresenter(this);
            presenter.CalculateArea();
        }

        
    }
}
