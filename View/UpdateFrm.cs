using System;
using System.Windows.Forms;
using PraktijkOpdracht.Controller;
using PraktijkOpdracht.Model;

// Author: Amer Sbeini
// Date: 10-05-2022
// Assignment: Praktijkopdracht


namespace PraktijkOpdracht.View
{
    public partial class UpdateFrm : Form
    {
        public static string Module;
        public static string Thema;
        public static string Taak;
        public static string Omschrijving;
        public static DateTime Startdatum;
        public static DateTime Inleverdatum;
        public static string Status;
        public static int TaakId;
        public static string taak;
        public static int rowsAffected;
        public int result;
        public static string action;
        public static string btnTextYes;
        public static string btnTextNo;
        public static string frmTitle;

        ToDoController toDoController = new ToDoController();
        ToDoView frmToDo = new ToDoView();

        public UpdateFrm(/*string UpdateFrmTitle*/)
        {
            InitializeComponent();
            lblUpdateTitle.Text = frmTitle;
/*            frmTitle = UpdateFrmTitle;
*/
        }

        private void btnYes_Click(object sender, EventArgs e)
        {

            Module = cbModule.SelectedItem.ToString();
            Thema = cbThema.SelectedItem.ToString();
            Taak = tbTaak.Text;
            Omschrijving = tbOmschrijving.Text;
            Startdatum = dtStartdatum.Value.Date;
            Inleverdatum = dtInleverdatum.Value.Date;
            Status = tbStatus.Text;
            btnTextYes = btnYes.Text;
            btnTextNo = btnNo.Text;

            ToDoModel toDoModel = new ToDoModel();

            if (action == "Create")
            {
                result = toDoController.Create(toDoModel);
            }
            else
            {
                result = toDoController.Delete();
            }

            //Bij succces dient de ListView opnieuw gevuld te worden.
            if (result > 0)
            {
                if (action == "Create")
                {
                    MessageBox.Show(
                        "Item " + taak + " met taakId " + TaakId + " is suucesvol toegevoegd!",
                        "Succesvol toegevoegd!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                else if (action == "Update")
                {
                    MessageBox.Show(
                        "Item " + taak + " met taakId " + TaakId + " is suucesvol gewijzigd!",
                        "Succesvol gewijzigd!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information
                        );
                }
                Close();
            }
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            MessageBox.Show(
                "Er is niks gewijzigd!",
                "Niks gewijzigd!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
                );
            Close();
        }

        private void UpdateFrm_Load(object sender, EventArgs e)
        {

        }
    }
}
