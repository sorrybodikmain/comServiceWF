using MaterialSkin.Controls;
using System;
using System.Linq;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.EntityFrameworkCore;
namespace comServiceWF.Forms
{
    public partial class AdminForm : MaterialForm
    {
        private Client currentClient;
        private void RefreshAll()
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            foreach (Client item in myServiceDb.Clients.OrderBy(c => c.Id))
            {
                dataGridView1.Rows.Add(item.Id, item.FullName, item.Phone, $"{item.Region}, {item.City}, {item.StreetFull}");
            }
            foreach (Team team in myServiceDb.Teams.OrderBy(t => t.Id))
            {
                dataGridView2.Rows.Add(team.Id, team.GetStatus);
            }
            foreach (Order item in myServiceDb.Orders.Include(o => o.Client).OrderBy(o => o.Id))
            {
                dataGridView3.Rows.Add(item.Id, item.Client.FullName, item.TypeOfWork, item.GetStatus,
                        item.DateOfWorks, item.DataCreate, item.toComplate());
            }
        }
        private void DeleteClient(int clientId)
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            Client? client = myServiceDb.Clients.FirstOrDefault(c => c.Id == clientId);
            if (client is not null)
            {
                myServiceDb.Clients.Remove(client);
                myServiceDb.SaveChanges();
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
                MaterialMessageBox.Show($"Removed client - {client.FullName}");
            }
            else
            {
                MaterialMessageBox.Show($"Client has already been removed!");
            }
        }
        private void DeleteTeam(int teamId)
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            Team? team = myServiceDb.Teams.FirstOrDefault(c => c.Id == teamId);
            if (team is not null)
            {
                myServiceDb.Teams.Remove(team);
                myServiceDb.SaveChanges();
                dataGridView2.Rows.RemoveAt(dataGridView2.SelectedRows[0].Index);
                MaterialMessageBox.Show($"Removed team - {team.Id}");
            }
            else
            {
                MaterialMessageBox.Show($"Team has already been removed!");
            }
        }
        private int GetIdWithTable(DataGridView dataGrid)
        {
            return Convert.ToInt32(dataGrid.Rows[dataGrid.SelectedRows[0].Index].Cells[0].Value);
        }
        private void AddWorker(int ID)
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            myServiceDb.Workers.Add(new Worker(boxFirstName.Text, boxLastName.Text, boxPhone.Text,
                                                Convert.ToInt32(boxSalary.Text), ID));
            boxFirstName.Text = ""; boxPhone.Text = ""; boxLastName.Text = ""; boxSalary.Text = "";
            myServiceDb.SaveChanges();
            MaterialMessageBox.Show("All saved");
        }
        private void PrintClient()
        {
            boxClientFirstName.Text = currentClient.FirstName;
            boxClientLastName.Text = currentClient.LastName;
            boxClientFullAdress.Text = currentClient.StreetFull;
            boxClientCity.Text = currentClient.City;
            boxClientPhone.Text = currentClient.Phone;
            boxClientRegion.Text = currentClient.Region;
        }
        private bool checkChanges()
        {
            if (boxClientFirstName.Text != currentClient.FirstName)
                return false;
            if (boxClientLastName.Text != currentClient.LastName)
                return false;
            if (boxClientPhone.Text != currentClient.Phone)
                return false;
            if (boxClientCity.Text != currentClient.City)
                return false;
            if (boxClientFullAdress.Text != currentClient.StreetFull)
                return false;
            if (boxClientRegion.Text != currentClient.Region)
                return false;

            return true;
        }
        public AdminForm()
        {
            InitializeComponent();
            RefreshAll();
            AuthForm.InitializeMaterial();
        }


        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("All client information and orders will be deleted! Do you agree?", "Warning",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                    DeleteClient(GetIdWithTable(dataGridView1));
                else
                    MaterialMessageBox.Show("Please select one row!");
            }
        }

        private void deleteTeamButton_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
            {
                DeleteTeam(GetIdWithTable(dataGridView2));
            }
            else
            {
                MaterialMessageBox.Show("Please select one team row!");
            }
        }

        private void addWorkerButton_Click(object sender, EventArgs e)
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            if (myServiceDb.Teams.Count() != 0)
            {
                if (dataGridView2.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
                {
                    AddWorker(GetIdWithTable(dataGridView2));
                }
                else
                {
                    MaterialMessageBox.Show("No selected rows!");
                }
            }
            else
            {
                myServiceDb.Teams.Add(new Team());
                myServiceDb.SaveChanges();
                dataGridView2.Rows.Add(1, "Not working");
                AddWorker(1);
            }
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            if (boxClientId.Text.Trim() != "")
            {
                int Id = Convert.ToInt32(boxClientId.Text.Trim());
                Client? client = myServiceDb.Clients.FirstOrDefault(c => c.Id == Id);
                if (client is not null)
                {
                    currentClient = client;
                    PrintClient();
                }
                else
                {
                    MaterialMessageBox.Show($"Does not have a client with such id - {Id}!");
                }
            }
            else
            {
                MaterialMessageBox.Show("Enter client ID!");
            }
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (checkChanges())
            {
                MaterialMessageBox.Show("No changes detected!");
            }
            else
            {
                MyServiceDb myServiceDb = new MyServiceDb();
                Client? client = myServiceDb.Clients.First(c => c.Id == currentClient.Id);
                if (client is not null)
                {
                    client.FirstName = boxClientFirstName.Text;
                    client.LastName = boxClientLastName.Text;
                    client.StreetFull = boxClientFullAdress.Text;
                    client.City = boxClientCity.Text;
                    client.Phone = boxClientPhone.Text;
                    client.Region = boxClientRegion.Text;
                    myServiceDb.SaveChanges();
                    MaterialMessageBox.Show("Everything is saved successfully!");
                }
                else
                {
                    MaterialMessageBox.Show($"Does not have a client with such id - {currentClient.Id}!");
                }
            }
        }

        private void buttonEditOrders_Click(object sender, EventArgs e)
        {
            if (dataGridView3.Rows.GetRowCount(DataGridViewElementStates.Selected) == 1)
            {
                MyServiceDb myServiceDb = new MyServiceDb();
                Order? order = myServiceDb.Orders.FirstOrDefault(o => o.Id == GetIdWithTable(dataGridView3));
                if (order != null)
                {
                    int TeamId = Convert.ToInt32(Interaction.InputBox("Enter TeamId:", "TeamId"));
                    Team? team = myServiceDb.Teams.FirstOrDefault(t => t.Id == TeamId);
                    if (team != null)
                    {
                        order.TeamId = TeamId;
                        team.UpdateStatus();
                        myServiceDb.SaveChanges();
                        MaterialMessageBox.Show("All saved");
                    }
                    else
                    {
                        MaterialMessageBox.Show("There is no such team!");
                    }
                }
            }
            else
            {
                MaterialMessageBox.Show("Please select one order row!");
            }
        }

        private void addTeamButton_Click(object sender, EventArgs e)
        {
            MyServiceDb myServiceDb = new MyServiceDb();
            myServiceDb.Teams.Add(new Team());
            myServiceDb.SaveChanges();
            Team team = myServiceDb.Teams.OrderByDescending(p => p.Id).First();
            dataGridView2.Rows.Add(team.Id, team.GetStatus);
        }
    }
}
