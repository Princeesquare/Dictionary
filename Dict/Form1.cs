using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dict
{
    public partial class Form1 : Form
    {
        private int ID = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mylist.View = View.Details;
            mylist.GridLines = true;
            mylist.FullRowSelect = true;

            mylist.Columns.Add("ID", 100, HorizontalAlignment.Center);
            mylist.Columns.Add("Word", 150, HorizontalAlignment.Center);
            mylist.Columns.Add("Meaning", 200, HorizontalAlignment.Center);

            selectedID.Enabled = false;
            selectedWord.Enabled = false;
            selectedMeaning.Enabled = false;
            deleteID.Enabled = false;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            if (WordBox.Text != "" && MeaningBox.Text != "")
            {
                ListViewItem R = new ListViewItem(ID.ToString());
                ListViewItem.ListViewSubItem C1 = new ListViewItem.ListViewSubItem(R, WordBox.Text);
                ListViewItem.ListViewSubItem C2 = new ListViewItem.ListViewSubItem(R, MeaningBox.Text);

                R.SubItems.Add(C1);
                R.SubItems.Add(C2);

                mylist.Items.Add(R);

                WordBox.Text = "";
                MeaningBox.Text = "";

                ID++;
            }
            else
                MessageBox.Show("Please Enter Word and Meaning!!");
        }

        private void mylist_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectedID.Text = mylist.FocusedItem.SubItems[0].Text;
            selectedWord.Text = mylist.FocusedItem.SubItems[1].Text;
            selectedMeaning.Text = mylist.FocusedItem.SubItems[2].Text;

            updateWord.Text = mylist.FocusedItem.SubItems[1].Text;
            updateMeaning.Text = mylist.FocusedItem.SubItems[2].Text;
            deleteID.Text = mylist.FocusedItem.SubItems[0].Text;
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (updateMeaning.Text == "" || updateWord.Text == "") MessageBox.Show("Please Select an Item you wish to Update.");

            if (mylist.FocusedItem != null)
            {
                mylist.FocusedItem.SubItems[1].Text = updateWord.Text;
                mylist.FocusedItem.SubItems[2].Text = updateMeaning.Text;

                updateWord.Text = "";
                updateMeaning.Text = "";
            }
            else
                MessageBox.Show("Please INSERT a list of items then select the one you want to Update.");
        }

        private void find_Click(object sender, EventArgs e)
        {
            if (findBox.Text == "") MessageBox.Show("Please Enter a Word to find the meaning..");

            else
            {
                for (int i = 0; i < mylist.Items.Count; i++)
                {
                    if (findBox.Text == mylist.Items[i].SubItems[1].Text)
                    {
                        findMeaningBox.Text = mylist.Items[i].SubItems[2].Text;
                        findBox.Text = "";
                        return;
                    }
                    findMeaningBox.Text = "Word Not Found!!";
                }
            }
        }

        private void Delete_Click_1(object sender, EventArgs e)
        {
            if (deleteID.Text == "")
                MessageBox.Show("Please Select an Item you wish to delete.");

            else
            {
                if (MessageBox.Show("Are You Sure You Want to DELETE the selected Item?", "Warning!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    int index = int.Parse(deleteID.Text) - 1;
                    mylist.Items[index].Remove();

                    //for (int i = index; i < mylist.Items.Count; i++) // use this line to search thru the list id if the user enters it manually
                    // {
                    int x = int.Parse(mylist.Items[index].SubItems[0].Text);
                    x--;
                    mylist.Items[index].SubItems[0].Text = x.ToString();
                    //}
                    MessageBox.Show("Item Deleted Successfully");
                    ID--;

                    deleteID.Text = "";
                    selectedID.Text = "";
                    selectedMeaning.Text = "";
                    selectedWord.Text = "";
                    updateMeaning.Text = "";
                    updateWord.Text = "";
                }
                else
                    return;
            }
        }
    }
}
