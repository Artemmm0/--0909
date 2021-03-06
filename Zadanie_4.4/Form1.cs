using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zadanie_4._4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private BindingSource sotrBindingSourse;
        private void Form1_Load(object sender, EventArgs e)
        {
            поставщикиTableAdapter1.Fill(rbProductDataSet1.Поставщики);
            sotrBindingSourse = new BindingSource(rbProductDataSet1, "Поставщики");
            FamtextBox.DataBindings.Add("Text", sotrBindingSourse, "Код поставщика");
            NametextBox.DataBindings.Add("Text", sotrBindingSourse, "Поставщик");
            SectiontextBox.DataBindings.Add("Text", sotrBindingSourse, "Телефон");
        }

        private void Previousbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MovePrevious();
        }

        private void Nextbutton_Click(object sender, EventArgs e)
        {
            sotrBindingSourse.MoveNext();
        }
    }
}
