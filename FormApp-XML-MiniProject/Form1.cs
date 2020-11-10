using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace FormApp_XML_MiniProject
{


    // TÜM DEĞİŞKENLER STRİNG OLSA SORUN OLUR MU??
    //LOADUSERS İÇERİDE USER OLMADIĞI ZAMAN PATLIYOR VE YENİ BİR KAYIT AÇARKEN ID OLADIĞI İÇİN 1 OLARAK ATAMIYOR

    public partial class Form1 : Form
    {
        string filePath = Application.StartupPath + @"\Users.xml";
        private List<User> list = new List<User>();
        User usr = new User();
        UserService usrSrvc = new UserService();
        public Form1()
        {
            InitializeComponent();
            txID.Visible = false;
            lbID.Visible = false;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            usrSrvc.filePath = filePath;

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            bool filePathBool = File.Exists(filePath);
            if (IsValid())
            {
                if (!filePathBool)
                {
                    userAdd();
                    var xDoc = usrSrvc.CreateUser(usr.Name, usr.Surname, usr.Birthdate, usr.Adress, usr.Job);
                    xDoc.Save(filePath);
                    loadUsers();
                    MessageBox.Show("Successfully added.", "Success", MessageBoxButtons.OK);
                }

                else if (filePathBool)
                {
                    userAdd();
                    var xDocLoad = usrSrvc.AddUser(usr.Name, usr.Surname, usr.Birthdate, usr.Adress, usr.Job);
                    xDocLoad.Save(filePath);
                    loadUsers();
                    MessageBox.Show("Successfully added.", "Success", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show("problem!", "Failed", MessageBoxButtons.OK);
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var xDoc = usrSrvc.UpdateUser(txName.Text, txSurname.Text, Convert.ToString(dateTimePicker1.Value), txAdress.Text, txJob.Text, txID.Text);
            xDoc.Save(filePath);
            loadUsers();
            Clear();
            btnAdd.Enabled = true;
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            MessageBox.Show("Updated.", "Update", MessageBoxButtons.OK);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (IsValid())
            {
                var xDoc = usrSrvc.DeleteUser(Convert.ToString(txID.Text));
                xDoc.Save(filePath);
                loadUsers();
                Clear();
                btnAdd.Enabled = true;
                btnUpdate.Enabled = false;
                btnDelete.Enabled = false;
                MessageBox.Show("Deleted.", "Success", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("");
            }
        }



    
     
        public void userAdd()
        {

            usr.Name = txName.Text;
            usr.Surname = txSurname.Text;
            usr.Birthdate = Convert.ToString(dateTimePicker1.Value.ToShortDateString());
            usr.Adress = txAdress.Text;
            usr.Job = txJob.Text;
            usr.ID = 1;
            list.Add(usr);
        }
        void loadUsers()
        {
            DataSet ds = new DataSet();
            XmlReader xmlFile;
            xmlFile = XmlReader.Create(filePath, new XmlReaderSettings());
            ds.ReadXml(xmlFile);
            if (ds != null && ds.Tables != null && ds.Tables.Count > 0)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }

            xmlFile.Close();
        }
        private bool IsValid()
        {
            if (txAdress.Text == string.Empty || txJob.Text == string.Empty || txName.Text == string.Empty || txSurname.Text == string.Empty)
            {
                MessageBox.Show("Please fill in all textboxes.", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;  
        }
        public void Clear()
        {
            txAdress.Text = "";
            txID.Text = "";
            txJob.Text = "";
            txName.Text = "";
            txSurname.Text = "";
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            btnAdd.Enabled = false;
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
            txID.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txName.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txSurname.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            dateTimePicker1.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txAdress.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txJob.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            loadUsers();
        }
    }
    }
 





