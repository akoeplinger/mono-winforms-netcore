using System;
using System.Windows.Forms;

namespace TestApp
{
    public class Form1 : Form
    {
        public Form1 ()
        {
            var b = new Button();
            b.Text = "Click me";
            b.Click += (s, e) => Console.WriteLine("Hello from WinForms!");

            var l = new Label();
            l.Text = "This is a label";
            l.Location = new System.Drawing.Point(50, 100);

            var t = new TextBox();
            t.Text = "This is a textbox";
            t.Location = new System.Drawing.Point(100, 50);

            this.Controls.Add(b);
            this.Controls.Add(l);
            this.Controls.Add(t);
        }
    }

    public class Program
    {
        public void Main (string[] args)
        {
            Console.WriteLine("Hello from KRE!");

            Application.EnableVisualStyles();
            Application.Run(new Form1());
        }
    }
}
