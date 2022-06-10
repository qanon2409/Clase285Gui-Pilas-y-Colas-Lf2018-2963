using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase285Gui
{
    public partial class Form1 : Form
    {
        public Stack<string> lb = new Stack<string>();
        public Queue<string> lb2 = new Queue<string>();
        string z;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bPila_Click(object sender, EventArgs e)
        {
            bPila.Enabled = true;
            bCola.Enabled=false;
        }

        private void bCola_Click(object sender, EventArgs e)
        {
            bPila.Enabled = false;
            bCola.Enabled = true;

        }
        void Select(int b)
        {
          

            switch (b)
            {

                case 1:
                    {
                        if (bPila.Enabled) 
                        {
                            lb.Push(txtAgregar.Text);
                            txtAgregar.Clear();
                            listado.DataSource = lb.ToList();

                        }


                        else
                        {
                            lb2.Enqueue(txtAgregar.Text);
                            txtAgregar.Clear();
                            listado.DataSource = lb2.ToList();

                        }
                            

                        break;
                    }

                    

                case 2:
                    {
                        if (bPila.Enabled)
                        {
                            z=lb.Pop();
                            label2.Text += z;
                            if (lb.ToList().Count() == 0)
                            {
                                lb.ToList().Clear();
                                listado.DataSource = lb.ToList();

                            }
                            else
                            {
                                lb.ToList().RemoveAt(lb.ToList().Count() - 1);
                                listado.DataSource = lb.ToList();

                            }
                            /*lb.ToList().RemoveAt(lb.ToList().Count()-1);
                            listado.DataSource = lb.ToList();*/



                        }
                        else
                        {
                            z=lb2.Dequeue();
                            label2.Text += z;
                            
                            if (lb2.ToList().Count()==0)
                            {
                                lb2.ToList().Clear();
                                listado.DataSource = lb2.ToList();

                            }
                            else
                            {
                                lb2.ToList().RemoveAt(lb2.ToList().Count() - 1);
                                listado.DataSource = lb2.ToList();

                            }

                        }
                            
                        break;

                    }

                /*case 3:
                    
                   // MessageBox.Show(lb.ToArray()[0].ToString());
                    {
                        if (bPila.Enabled && lb.Count>0)
                        {
                            listado.DataSource = lb.ToList();
                           
                        }

                        else if(bCola.Enabled && lb.Count > 0)
                        {
                            foreach (var i in lb2)
                            {
                                listado.Items.Add(i);
                            }

                        }
                       // break;
                    }*/

               
            }

            
        }


        private void bAgregar_Click(object sender, EventArgs e)
        {
            Select(1);
            //Select(3);
          
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            Select(2);

        }

        private void listado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /*Stack<string> lb = new Stack<string>();
            Queue<string> lb2 = new Queue<string>();
            if (bPila.Enabled)
            {
                lb.Push(txtAgregar.Text);
            }
            else
            {
                lb2.Enqueue(txtAgregar.Text);

            }*/
    }
}
