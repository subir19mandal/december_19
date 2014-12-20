using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerQueueManagementUIApp
{
    public partial class CustomerService : Form
    {
        Queue<Customer> customers = new Queue<Customer>();
        int count = 0;

        public CustomerService()
        {
            InitializeComponent();
        }

        private void enqueueButton_Click(object sender, EventArgs e)
        {

            Customer aCustomer = new Customer();
            count++;
            aCustomer.name = nameAddTextBox.Text;
            aCustomer.complain = complainAddTextBox.Text;
            aCustomer.serial = count;

            customers.Enqueue(aCustomer);
            

            ListViewItem aListViewItem = new ListViewItem();

            aListViewItem.Text = Convert.ToString(aCustomer.serial);
            aListViewItem.SubItems.Add(aCustomer.name);
            aListViewItem.SubItems.Add(aCustomer.complain);
            waitingQueueListView.Items.Add(aListViewItem);
            MessageBox.Show(aCustomer.name + ", your serial number is " + aCustomer.serial);

        }

        private void dequeueButton_Click(object sender, EventArgs e)
        {
            if (waitingQueueListView.Items.Count>0)
            {
                Customer aCustomer = new Customer();
                aCustomer = customers.Dequeue();

                serialNoTextBox.Text = Convert.ToString(aCustomer.serial);
                nameShowTextBox.Text = aCustomer.name;
                complainShowTextBox.Text = aCustomer.complain;
                waitingQueueListView.Items.RemoveAt(0);
            }
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        
    }
}

