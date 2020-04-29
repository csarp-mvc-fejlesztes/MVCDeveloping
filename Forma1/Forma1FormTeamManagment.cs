using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Forma1.controller;
using Forma1.myexeption;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        /// <summary>
        /// Belső függvény
        /// A csapat nevek lekérése a controller segítségével és a csapat ListBox frissítése az adatokkal
        /// A csapat nevek megadására szolgáló TextBox legyen üres
        /// Ha a versenyzőket tartlamazó ListBox üres, akkor clerRacerTextBox belső függvény hívása
        /// </summary>
        private void updateTeamNameListBox()
        {
            listBoxTeam.DataSource = null;
            listBoxTeam.DataSource = controller.
            textBoxNewTeamName.Text = string.Empty;
            if (listBoxRacer.Items.Count==0)
            {
                clearRacerTextBox();
            }
        }

        /// <summary>
        /// Annak a ComboBox-nak a módosítása, amelyik segítségével az egyik csapatból a másikba lehet átrakni egy versenyzőt
        /// Ha a csapatokat és versenyzőket tartalmazó listBox-ok üressek akkor a ComboBox legyen üres
        /// Kükönben olvassa ki a csapatok ListBox-ból a kiválasztott elemet
        /// Kontroller réteg segítségével kérje le a ComboBox-ba megjelenítendő adatokat (getTeamNamesListExclude)
        /// Töltse fel a ComboBox-ot a megkapot csapatnevekkel
        /// Ha a ComboBoxban több csapatnév van, akkor legyen az első a kiválasztott
        /// Ha 
        /// </summary>
        private void updateComboBoxTeamMove()
        {
            if ((listBoxTeam.SelectedIndex >= 0) && (listBoxRacer.Items.Count > 0))
            {
                string teamName = listBoxTeam.Text;
                List<string> teamsExcludeSelected = controller.getTeamNamesListExclude(teamName);
                comboBoxTeamMove.DataSource = 
                comboBoxTeamMove.DataSource = 
                if (comboBoxTeamMove.Items.Count > 0)
                    comboBoxTeamMove.SelectedIndex = 0;
            }
            else
            {
                comboBoxTeamMove.DataSource = null;
            }
        }

        /// <summary>
        /// A felhasználó egy másik csapatot választ a ListBox-ban
        /// Ha nincs kiválasztott elem, akkor a ComboBox-ot törölje és azt a TextBox-ot is ahol az új csapatneveket lehet megadni és térjen vissza
        /// Különben olvassa ki a ListBoxban kiválasztott csapatnevet, kérje le a csapathoz tartozó versenyzők nevét
        /// A versenyző neveket jelenítse meg a versenyzők ListBox-ban
        /// Frissítse a ComboBox tartalmát (updateComboBoxTeamMove)
        /// Törölje a versenyző TextBoxait ha szükséges (clearRacerTextBox)
        /// </summary>
        private void listBoxTeam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex )
            {
                textBoxNewTeamName.Text = string.Empty;
                comboBoxTeamMove.DataSource = null;
                return;
            }
            string teamName = listBoxTeam.Text;
            List<string> racerNames = controller.getTeamRacersName(teamName);
            listBoxRacer.DataSource = racerNames;
            updateComboBoxTeamMove();
            clearRacerTextBox();
        }

        /// <summary>
        /// Új csapatnév megadása
        /// Olvassa ki a csapat nevet
        /// A kontroller réteg segítségével adja vegye fel az adatot
        /// Ha a kontroller réteg hibát dob, jelenítse meg a hiba szövegét az errorProviderAddTeam segítségével. Biztosítsa az ErrorProvider törlését is!
        /// Frissítse a csapatnevek ListBox-ot a updateTeamNameListBox segítségével
        /// </summary>
        private void buttonAddTeam_Click(object sender, EventArgs e)
        {
            string teamName = 
            errorProviderAddTeam.Clear();
            try
            {
                controller.addTeamToF1(teamName);
                updateTeamNameListBox();
            }
            catch (ControllerException ce)
            {
                errorProviderAddTeam.SetError(buttonAddTeam, ce.Message);
            }
        }

        /// <summary>
        /// Csapat nevének módosítása
        /// Olvassa ki a csapatokat tartlamazó Listbox-ból a kiválasztot csapatot
        /// Olvassa ki a csapat új nevét a megfelelő TextBox-ból
        /// A kontroller réteg segítségével módosítsa a csapat nevét
        /// Frissítse a csapatneveket tartalmazó ListBox-ot (updateTeamNameListBox)
        /// Frissítse a ComboBox-ot (updateComboBoxTeamMove)
        /// Ha a kontroller réteg hibád dob jelenítse azt meg az errorProviderUpdateTeam-ben. Biztosítsa az ErrorProvider törlését is! 
        /// </summary>
        private void buttonUpdateTeam_Click(object sender, EventArgs e)

        {
            errorProviderUpdateTeam.Clear();
            try
            {
                string newTeamName = 
                string oldTeamName = 
                controller.modifyTeamName(oldTeamName, newTeamName);
                updateTeamNameListBox();
                updateComboBoxTeamMove();
            }
            catch (ControllerException ce)
            {
                errorProviderUpdateTeam.SetError(buttonUpdateTeam, ce.Message);
            }
        }

        /// <summary>
        /// Csapat törlése
        /// Olvassa ki a törlendő csapat nevét, amely a csapatokat tartalmazó ListBox kiválasztott eleme lesz
        /// Törölje a kontroller réteg segítségével a csapatot
        /// Frissítse a csapatneveket tartalmazó ListBox-ot (updateTeamNameListBox)
        /// Frissítse a ComboBox-ot (updateComboBoxTeamMove)
        /// Ha a kontroller réteg hibád dob jelenítse azt meg az errorProviderDeleteTeam-ben. Biztosítsa az ErrorProvider törlését is! 
        /// </summary>        
        private void buttonUpdateTeam_Click(object sender, EventArgs e)
        {
            errorProviderDeleteTeam.Clear();
            try
            {
                string teamNameToDelete = 
                controller.
                updateTeamNameListBox();
                updateComboBoxTeamMove();
            }
            catch (ControllerException ce)
            {
                errorProviderDeleteTeam.SetError(buttonDeleteTeam, ce.Message);
            }
        }

        /// <summary>
        /// Jelenítse meg a Controller réteg segítségével az F1 költségvetését
        /// </summary>
        private void buttonComputeF1Salary_Click(object sender, EventArgs e)
        {
            try
            {
                textBoxF1Salary.Text = controller.getF1Salary();
            }
            catch (ControllerException ce)
            {
            }
        }
    }
}
