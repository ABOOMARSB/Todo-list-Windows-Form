using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using PraktijkOpdracht.View;
using PraktijkOpdracht.Model;

// Author: Amer Sbeini
// Date: 10-05-2022
// Assignment: Praktijkopdracht

namespace PraktijkOpdracht.Controller
{
    internal class ToDoController
    {
        private string connectionString = ConfigurationManager.ConnectionStrings["connectionStringPraktijk"].ConnectionString;
        private int affectedRows;

        public List<ToDoModel> ReadAll()
        {
            //Aanmaken object toDoList van datatype List<> gebaseerd op model ToDoModel
            List<ToDoModel> toDoList = new List<ToDoModel>();

            //Using: stukje code dat wordt gebruikt en opgeruimd na gebruik
            //Creer een nieuw SqlConnection object con met de gemaakte connectionString
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                string sqlQuery;

                if(ToDoView.ModuleValue != null && ToDoView.ThemaValue != null)
                {
                    sqlQuery = "SELECT Taak.*, Module.ModuleNaam, Thema.ThemaNaam FROM Taak INNER JOIN [Module] ON Module.ModuleID = Taak.ModuleId INNER JOIN [Thema] ON Module.ThemaId = Thema.ThemaId WHERE Taak.ModuleId = Module.ModuleId AND Module.ModuleNaam = @ModuleNaamValue AND Thema.ThemaNaam = @ThemaNaamValue;";
                }
                else if (ToDoView.ModuleValue != null)
                {
                    sqlQuery = "SELECT Taak.*, Module.ModuleNaam, Thema.ThemaNaam FROM Taak INNER JOIN [Module] ON Module.ModuleID = Taak.ModuleId INNER JOIN [Thema] ON Module.ThemaId = Thema.ThemaId WHERE Module.ModuleNaam = @ModuleNaamValue;";
                }
                else if (ToDoView.ThemaValue != null)
                {
                    sqlQuery = "SELECT Taak.*, Module.ModuleNaam, Thema.ThemaNaam FROM Taak INNER JOIN [Module] ON Module.ModuleID = Taak.ModuleId INNER JOIN [Thema] ON Module.ThemaId = Thema.ThemaId WHERE Thema.ThemaNaam = @ThemaNaamValue;";
                }
                else
                {
                    sqlQuery = "SELECT Taak.*, Module.ModuleNaam, Thema.ThemaNaam FROM Taak INNER JOIN [Module] ON Module.ModuleID = Taak.ModuleId INNER JOIN [Thema] ON Module.ThemaId = Thema.ThemaId";
                }

                //Using gebruiken voor de query: command
                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    if (ToDoView.ModuleValue != null)
                    {
                        command.Parameters.AddWithValue("ModuleNaamValue", ToDoView.ModuleValue);
                    }
                    if (ToDoView.ThemaValue != null)
                    {
                        command.Parameters.AddWithValue("ThemaNaamValue", ToDoView.ThemaValue);
                    }

                    con.Open();

                    //Data ophalen
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read()) //Boolean i.p.o. reader.Read() = true
                    {
                        ToDoModel ToDo = new ToDoModel();

                        ToDo.Module = (string)reader["ModuleNaam"];
                        ToDo.Thema = (string)reader["ThemaNaam"];
                        ToDo.TaakId = (int)reader["TaakId"];
                        ToDo.Taak = (string)reader["Naam"];

                        if (reader["Omschrijving"] != DBNull.Value)
                        {
                            ToDo.Omschrijving = (string)reader["Omschrijving"];
                        }
                        else
                        {
                            ToDo.Omschrijving = Convert.ToString("-_-");
                        }
                        ToDo.InleverDatum = (DateTime)reader["Startdatum"];
                        ToDo.StartDatum = (DateTime)reader["Inleverdatum"];
                        ToDo.Status = (string)reader["Status"];

                        //ToDoList met data vullen
                        toDoList.Add(ToDo);
                    }
                    con.Close();
                }
                return toDoList;
            }
        }

        public int Update()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                UpdateFrm updateFrm = new UpdateFrm();

                // Update query voor Module en Taak met Module, taak en thema variablen
                string sqlQuery =
                    "UPDATE Taak SET Naam = '" + UpdateFrm.Taak +
                    "', Omschrijving = '" + UpdateFrm.Omschrijving +
                    "', Startdatum = '" + UpdateFrm.Startdatum +
                    "', Inleverdatum = '" + UpdateFrm.Inleverdatum +
                    "', Status = '" + UpdateFrm.Status +
                    "', ModuleId = (SELECT ModuleId FROM Module WHERE ModuleNaam = (SELECT ModuleNaam FROM Module WHERE @ModuleNaamValue = ModuleNaam AND ThemaId = (SELECT ThemaId FROM Thema WHERE ThemaNaam = @ThemaNaamValue)) AND ThemaId = (SELECT ThemaId FROM Thema WHERE ThemaNaam = @ThemaNaamValue)) FROM Module INNER JOIN Taak ON Taak.ModuleId = Module.ModuleId WHERE Taak.ModuleId = Module.ModuleId AND TaakId = @TaakIdValue";

                //Update query voor Thema en Module met Module, Taak en Thema variabelen
                string sqlQueryUpdateModuleThemId =
                    "UPDATE Module SET ThemaId = (SELECT ThemaId FROM Module WHERE ThemaId = (SELECT ThemaId FROM Thema WHERE @ThemaNaamValue = ThemaNaam) AND @ModuleNaamValue = ModuleNaam) FROM Module INNER JOIN Thema ON Thema.ThemaId = Module.ThemaId WHERE Thema.ThemaNaam = (SELECT ThemaNaam FROM Thema WHERE ThemaNaam = @ThemaNaamValue) AND @ModuleNaamValue = ModuleNaam;";

                // Start een SQL Command
                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    // command, dus query, uitvoeren met geselecteerde variabele.
                    command.Parameters.AddWithValue("TaakIdValue", UpdateFrm.TaakId);
                    command.Parameters.AddWithValue("ModuleNaamValue", UpdateFrm.Module);
                    command.Parameters.AddWithValue("ThemaNaamValue", UpdateFrm.Thema);

                    con.Open();

                    using (SqlCommand commandUpdateModuleThemaId = new SqlCommand(sqlQueryUpdateModuleThemId, con))
                    {
                        commandUpdateModuleThemaId.Parameters.AddWithValue("ModuleNaamValue", UpdateFrm.Module);
                        commandUpdateModuleThemaId.Parameters.AddWithValue("ThemaNaamValue", UpdateFrm.Thema);

                        commandUpdateModuleThemaId.ExecuteNonQuery();
                    }

                    // int dat terugkrijgt hoeveel rijen er aangepast zijn (Aangepast)
                    affectedRows = command.ExecuteNonQuery(); // hier krijg je terug: een int
                }
            }
            return affectedRows;
        }

        public int Delete()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                // delete query met variable
                string sqlQuery = "DELETE FROM Taak WHERE TaakId = @TaakIdValue";

                // Start een SQL Command
                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    // command, dus query, uitvoeren met geselecteerde variabele.
                    command.Parameters.AddWithValue("TaakIdValue", DeleteFrm.TaakId);

                    con.Open();

                    // int dat terugkrijgt hoeveel rijen er aangepast zijn (verwijderd)
                    affectedRows = command.ExecuteNonQuery(); // hier krijg je terug: een int
                }
            }

            return affectedRows;
        }

        public int Create(ToDoModel toDoModel)
        {
            UpdateFrm.btnTextYes = "Toevoegen";
            UpdateFrm.btnTextNo = "Graag niet";
            int affectedRows = 0;

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                UpdateFrm updateFrm = new UpdateFrm();

                string sqlQuery = "INSERT INTO Taak (Naam, Omschrijving, Startdatum, Inleverdatum, Status, ModuleId) " +
                    "VALUES ('"
                    + UpdateFrm.Taak + "','"
                    + UpdateFrm.Omschrijving + "','"
                    + UpdateFrm.Startdatum + "','"
                    + UpdateFrm.Inleverdatum + "','"
                    + UpdateFrm.Status +
                    "', (SELECT ModuleId FROM Module WHERE ModuleNaam = @ModuleNaamValue AND ThemaId = (SELECT ThemaId FROM Thema WHERE ThemaNaam = @ThemaNaamValue)));";

                using (SqlCommand command = new SqlCommand(sqlQuery, con))
                {
                    command.Parameters.AddWithValue("ThemaNaamValue", UpdateFrm.Thema);
                    command.Parameters.AddWithValue("ModuleNaamValue", UpdateFrm.Module);

                    con.Open();

                    //Hier krijgt ie waarde 1 als het wordt uitgevoerd
                    affectedRows = command.ExecuteNonQuery();
                }
            }

            return affectedRows; //Gaat het goed 1, Niet? 0
        }

    }
}