using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace İlk_Harf_Buyuk
{
    public partial class Form1 : Form
    {
        #region

        int a;

        string cümle;

        #endregion

        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

            cümle = textBox1.Text;

            if (cümle.Length == 1)
            {
               textBox1.Text = cümle.ToUpper();
               

                textBox1.SelectionStart = textBox1.TextLength;
                textBox1.Focus();
            }

            else if (cümle.Length - 1 == a)
            {
                cümle = cümle.Substring(0, a) + cümle.Substring(a-1).ToUpper();
                textBox1.Text = cümle;
                a = 0;

                textBox1.SelectionStart = textBox1.TextLength;
                textBox1.Focus();
            }

            else if (cümle.Length==a)
            {
                textBox1.Text = cümle;
            }

       }

        
        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                
                a = textBox1.Text.Length+1;
                textBox1.SelectionStart = textBox1.TextLength;
                textBox1.Focus();
                textBox1.Enabled = true;

            }
        }

      
    }
}
