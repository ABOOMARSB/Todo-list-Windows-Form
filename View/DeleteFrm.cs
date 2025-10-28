using System;
using System.Windows.Forms;
using PraktijkOpdracht.Controller;

namespace PraktijkOpdracht.View
{
    public partial class DeleteFrm : Form
    {
        public ListView lvAction;
        public static int TaakId;
        public static string taak;
        public int result;

        ToDoController toDoController = new ToDoController();

        public DeleteFrm(string DeleteTitle)
        {
            InitializeComponent();

            lblDeleteTitle.Text = DeleteTitle;
            lvAction = lvDeleteFrm;
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            // uitleg try catch (try catch finally)
            // beter is de try catch in de controller te doen
            try
            {
                result = toDoController.Delete();

                // Bij succces dient een melding te verschijnen.
                if (result > 0)
                {
                    MessageBox.Show(
                    "Item " + taak + " met taakId " + TaakId + " is suucesvol verwijderd!",
                    "Succesvol verwijderd!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
                    Close();
                }
            }
            catch
            {
                MessageBox.Show("Er is iets misgegaan tijdens het wijzigen . . .");
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Er is niks verwijderd!",
                "Niks verwijderd!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            Close();
        }

        private void DeleteFrm_Load(object sender, EventArgs e)
        {
            //Create listview Columns
            lvDeleteFrm.Columns.Add("Thema", 75);
            lvDeleteFrm.Columns.Add("Module", 100);
            lvDeleteFrm.Columns.Add("Taak", 75);
            lvDeleteFrm.Columns.Add("Omschrijving", 125);
            lvDeleteFrm.Columns.Add("Startdatum", 100);
            lvDeleteFrm.Columns.Add("Inleverdatum", 100);
            lvDeleteFrm.Columns.Add("Status", 75);

            lvDeleteFrm.FullRowSelect = true;
            lvDeleteFrm.View = System.Windows.Forms.View.Details;
            lvDeleteFrm.HeaderStyle = ColumnHeaderStyle.Clickable;
        }
    }
}
