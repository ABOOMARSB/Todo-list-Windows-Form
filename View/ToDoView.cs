using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using PraktijkOpdracht.Model;
using PraktijkOpdracht.Controller;
using System.Text;
using System.IO;

namespace PraktijkOpdracht.View
{
    public partial class ToDoView : Form
    {
        string frmTitle;
        public static ListView lvItems;
        public int itemId;
        public static int TaakId;
        public static string ModuleValue;
        public static string ThemaValue;

        ToDoController toDoController = new ToDoController();

        public ToDoView()
        {
            InitializeComponent();

            lvItems = lvToDo;
            if (cbModuleFilter.SelectedItem != null)
            {
                ModuleValue = cbModuleFilter.SelectedItem.ToString();
            }

            if (cbThemaFilter.SelectedItem != null)
            {
                ThemaValue = cbThemaFilter.SelectedItem.ToString();
            }
        }

        private void ToDoView_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();
            MainView MainView = new MainView();
            MainView.ShowDialog();
            Close();
        }

        private void ToDoView_Load(object sender, EventArgs e)
        {
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;

            //Create listview Columns
            lvToDo.Columns.Add("Thema", 75);
            lvToDo.Columns.Add("Module", 100);
            lvToDo.Columns.Add("Taak", 75);
            lvToDo.Columns.Add("Omschrijving", 125);
            lvToDo.Columns.Add("Startdatum", 100);
            lvToDo.Columns.Add("Inleverdatum", 100);
            lvToDo.Columns.Add("Status", 75);

            lvToDo.FullRowSelect = true;
            lvToDo.View = System.Windows.Forms.View.Details;
            lvToDo.HeaderStyle = ColumnHeaderStyle.Clickable;

            FillListView();
        }
        public void FillListView()
        {
            List<ToDoModel> ToDoList = toDoController.ReadAll();

            lvToDo.Items.Clear();

            foreach (ToDoModel toDo in ToDoList)
            {
                // Hier kun je code schrijven die met elke taak uit de ToDoList.
                // iets doet. Wij willen deze toDo's hier toevoegen aan de listview.
                ListViewItem lvItem = new ListViewItem(toDo.Thema.ToString());
                lvItem.SubItems.Add(toDo.Module.ToString());
                lvItem.SubItems.Add(toDo.Taak.ToString());
                lvItem.SubItems.Add(toDo.Omschrijving.ToString());
                lvItem.SubItems.Add(toDo.StartDatum.ToString("dd-MM-yyyy"));
                lvItem.SubItems.Add(toDo.InleverDatum.ToString("dd-MM-yyyy"));
                lvItem.SubItems.Add(toDo.Status.ToString());

                lvItem.Tag = toDo;

                lvToDo.Items.Add(lvItem);
            }
        }

        public void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                // haal het object uit de geselecteerde rij
                ToDoModel SelectedItem = (ToDoModel)lvToDo.SelectedItems[0].Tag;

                //Confirm delete message
                frmTitle = "Weet je het zeker dat je opdracht " + SelectedItem.Taak + " Van " + SelectedItem.Module + " wil verwijderen?";

                DeleteFrm frmDelete = new DeleteFrm(frmTitle);

                DeleteFrm.TaakId = SelectedItem.TaakId;
                DeleteFrm.taak = SelectedItem.Taak;

                //Show delete form
                frmDelete.ShowDialog();
                int result = frmDelete.result;

                // uitleg try catch (try catch finally)
                // beter is de try catch in de controller te doen
                try
                {
                    // Bij succces dient de ListView opnieuw gevuld te worden.
                    if (result > 0)
                    {
                        FillListView();
                    }
                }
                catch
                {
                    MessageBox.Show("Er is iets misgegaan tijdens het refreshen . . .");
                }
            }
            catch
            {
                MessageBox.Show(
                    "Er is iets misgegaan, selecteer een item en probeer het opnieuw . . .",
                    "Je hebt geen item geselecteerd!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        //Edit functionality
        public void btnEdit_Click(object sender, EventArgs e)
        {
            // haal het object uit de geselecteerde rij
            UpdateFrm updateFrm = new UpdateFrm();
            ToDoModel SelectedItem = (ToDoModel)lvToDo.SelectedItems[0].Tag;
            UpdateFrm.TaakId = SelectedItem.TaakId;

            //Define variabelen
            UpdateFrm.action = "Edit";
            UpdateFrm.frmTitle = "Vul onderstaande gegevens om de taak " + SelectedItem.Taak + "aan te passen.";

            try
            {
                //Show form title
                frmTitle = "Weet je het zeker dat je opdracht " + SelectedItem.Taak + " Van " + SelectedItem.Module + " wilt wijzigen?";

                //Show delete form
                updateFrm.ShowDialog();
                int result = updateFrm.result;

                // uitleg try catch (try catch finally)
                // beter is de try catch in de controller te doen
                try
                {
                    // Bij succces dient de ListView opnieuw gevuld te worden.
                    if (result > 0)
                    {
                        FillListView();
                    }
                }
                catch
                {
                    MessageBox.Show("Er is iets misgegaan tijdens het wijzigen . . .");
                }
            }
            catch
            {
                MessageBox.Show(
                    "Er is iets misgegaan, selecteer een item en probeer het opnieuw . . .",
                    "Je hebt geen item geselecteerd!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }

        private async void btnExport_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter streamWriter = new StreamWriter(new FileStream(saveFileDialog.FileName, FileMode.Create), Encoding.UTF8))
                    {
                        StringBuilder stringBuilder = new StringBuilder();
                        stringBuilder.AppendLine("Thema, Module, Taak, Omschrijving, Startdatum, Inleverdatum, Status");
                        foreach (ListViewItem item in lvToDo.Items)
                        {
                            stringBuilder.AppendLine(string.Format("{0},{1},{2},{3},{4},{5},{6}", item.SubItems[0].Text, item.SubItems[1], item.SubItems[2].Text, item.SubItems[3].Text, item.SubItems[4].Text, item.SubItems[5].Text, item.SubItems[6].Text));
                        }
                        await streamWriter.WriteLineAsync(stringBuilder.ToString());
                        MessageBox.Show("Bestand is succesvol naar: " + saveFileDialog.FileName + " gexporteerd.", "Bericht", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (cbModuleFilter.SelectedItem != null)
            {
                ModuleValue = cbModuleFilter.SelectedItem.ToString();
            }
            if (cbThemaFilter.SelectedItem != null)
            {
                ThemaValue = cbThemaFilter.SelectedItem.ToString();
            }

            FillListView();

            ThemaValue = null;
            ModuleValue = null;

        }

        private void btnResteFilters_Click(object sender, EventArgs e)
        {
            FillListView();

            cbModuleFilter.SelectedItem = null;
            cbThemaFilter.SelectedItem = null;
        }

        public void btnCreate_Click(object sender, EventArgs e)
        {
            UpdateFrm.action = "Create";
            UpdateFrm.frmTitle = "Voer onderstaande gegevens om een nieuwe taak toe te voegen.";

            try
            {
                UpdateFrm updateFrm = new UpdateFrm(/*frmTitle*/);

                //Show delete form
                updateFrm.ShowDialog();
                int result = updateFrm.result;

                // uitleg try catch (try catch finally)
                // beter is de try catch in de controller te doen
                try
                {
                    // Bij succces dient de ListView opnieuw gevuld te worden.
                    if (result > 0)
                    {
                        FillListView();
                    }
                }
                catch
                {
                    MessageBox.Show("Er is iets misgegaan tijdens het toevoegen . . .");
                }
            }
            catch
            {
                MessageBox.Show(
                    "Er is iets misgegaan, selecteer een item en probeer het opnieuw . . .",
                    "Je hebt geen item geselecteerd!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }

        }
    }
}
