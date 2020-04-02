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
using Forma1.repository;

namespace Forma1
{
    public partial class Form1Form : Form
    {
        /// <summary>
        /// A versenyző beviteli TextBox-jainak törlése, ha kiválasztotta ezt a gombot!
        /// </summary>
        private void buttonClearRacerTextBox_Click(object sender, EventArgs e)
        {
            textBoxRacerName.Text = string.Empty;
            textBoxRacerAge.Text = string.Empty;
            textBoxRacerSalary.Text = string.Empty;
        }

        /// <summary>
        /// Ha a versenyzőket tartalmazó ListBox üres akkor törli a versenyző adatbeviteli TextBox-ait
        /// </summary>
        private void clearRacerTextBox()
        {
            if (listBoxRacer.Items.Count == 0)
            {
                textBoxRacerName.Text = string.Empty;
                textBoxRacerAge.Text = string.Empty;
                textBoxRacerSalary.Text = string.Empty;
            }
        }

        /// <summary>
        /// Kontroller réteg segítségével frissíti a versenyzőket tratalmazó ListBox-ot
        /// Ha a ListBox üres akkor törli a versenyző adatbeviteli TextBox-ait (clearRacerTextBox)
        /// Frissíti a ComboBox-ot (updateComboBoxTeamMove)
        /// </summary>
        /// <param name="teamName"></param>
        private void updateRacerNameListBox(string teamName)
        {
            listBoxRacer.DataSource = null;
            List<string> racerNames = controller.getTeamRacersName(teamName);
            listBoxRacer.DataSource = racerNames;
            if (listBoxRacer.Items.Count == 0)
                clearRacerTextBox();
            updateComboBoxTeamMove();
        }

        /// <summary>
        /// A felhasználó egy másik versenyzőt választ ki
        /// Ha nincs kiválasztott elem, akkor visszatérés
        /// Olvassa ki a megfelelő ListBox-ból a kiválasztott csapat nevét
        /// Olvassa ki a megfelelő ListBox-ból a kiválasztott versenyzőt
        /// A kontroller réteg segítségével olvassa ki a két adat alapján meghatározott versenyzőt
        /// Ha az nem null, akkor adatit jelenítse meg a megfelelő TextBox-okban
        /// </summary>
        private void listBoxRacer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxRacer.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.Text;
            string racerName = listBoxRacer.Text;

            Racer selectedRacer = controller.searchRacerByName(teamName, racerName);
            if (selectedRacer != null)
            {
                textBoxRacerName.Text = selectedRacer.getName();
                textBoxRacerAge.Text = selectedRacer.getAge().ToString();
                textBoxRacerSalary.Text = selectedRacer.getSalary().ToString();
            }
        }

        /// <summary>
        /// Versenyző hozzáadása a csapathoz
        /// Ha nincs kiválasztott csapat jelenítse meg a következő hibaüzenetet a errorProviderAddRacer-ben: "Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet hozzáadni a csapathoz új versenyzőt!"
        /// Olvassuk ki a kiválasztott csapatot, a megadott versenyző nevet, életkort és bérét a megfelelő TextBox-okból
        /// A kontroller réteg segítségével adja hozzá a versenyzőt (a csapathoz)
        /// Ezután frissítse a versenyzők Listbox-ot (updateRacerNameListBox)
        /// Ha a kontroller réteg hibát dob, jelenítse meg a hiba szövegét az errorProviderAddRacer segítségével. Biztosítsa az ErrorProvider törlését is!
        /// </summary>
        private void buttonAddRacer_Click(object sender, EventArgs e)
        {
            errorProviderAddRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0)
            {
                errorProviderAddRacer.SetError(buttonAddRacer, "Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet hozzáadni a csapathoz új versenyzőt!");
                return;
            }
            errorProviderAddRacer.Clear();
            string teamName = listBoxTeam.Text;
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;
            try
            {
                controller.addRacerToTeam(teamName, racerName, racerAge, racerSalary);
                updateRacerNameListBox(teamName);
            }
            catch (ControllerException ce)
            {
                errorProviderAddRacer.SetError(buttonAddRacer, ce.Message);
            }
        }

        /// <summary>
        /// Ha nincs csapat kijelölve a megfelelő ListBox-ban akkor az errorProviderUpdateRacer segítségével jelnítsük meg a következő hibát:"Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet módosítani a versenyzőjét!". Ezután térjen vissza.
        /// Ha nincs kijelölt versenyző a megfelelő Listbox-ban akkor errorProviderUpdateRacer segítségével jelenítsük meg a következő hibát:"Ha nincs versenyző kijelölve, akkor nem lehet módosítani a versenyzőjét!". Ez után térj vissza.
        /// Ha nincs hiba olvassuk ki a csapat nevét a megfelelő ListBox-ból
        /// Olvassuk ki a megfelelő ListBox-ból a módosítandó versenyző nevét
        /// Ezután olvassuk ki a megfelelő TextBox-okból a versenyző adatokat (erre fogunk módosítani)
        /// A kontroller réteg segítségével módosítsa az adott csapatban tartozó versenyzőt
        /// Ha sikerül a módosítás frissítse a versenyző Listbox-ot (updateRacerNameListBox)
        /// Ha a kontroller réteg hibát dob, jelenítse meg a hiba szövegét az errorProviderUpdateRacer segítségével. Biztosítsa az ErrorProvider törlését is!
        /// </summary>
        private void buttonUpdateRacer_Click(object sender, EventArgs e)
        {
            errorProviderUpdateRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0)
            {
                errorProviderUpdateRacer.SetError(buttonUpdateRacer, "Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet módosítani a versenyzőjét!");
                return;
            }
            if (listBoxRacer.SelectedIndex < 0)
            {
                errorProviderUpdateRacer.SetError(buttonUpdateRacer, "Ha nincs versenyző kijelölve, akkor nem lehet módosítani a versenyzőjét!");
                return;
            }
            string teamName = listBoxTeam.Text;
            string racerToModify = listBoxRacer.Text;
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            string racerSalary = textBoxRacerSalary.Text;
            try
            {
                controller.updateRacerInTeam(teamName, racerToModify, racerName, racerAge, racerSalary);
                updateRacerNameListBox(teamName);
            }
            catch (ControllerException ce)
            {
                errorProviderUpdateRacer.SetError(buttonUpdateRacer, ce.Message);
            }
        }

        /// <summary>
        /// A kiválasztott versenyző törlése
        /// Ha nincs kiválasztott csapat akkor jelenjen meg a következő hibaüzenet: "Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet törölni a csapathoz tartozó versenyzőt!", majd térjen vissza
        /// Ha nincs kijelölt versenyző a megfelelő Listbox-ban akkor errorProviderDeleteRacer segítségével jelenítsük meg a következő hibát:"Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet törölni a csapathoz tartozó versenyzőt!"), majd térjen vissza
        /// Ha nincs hiba olvassuk ki a csapat nevét a megfelelő ListBox-ból
        /// Olvassuk ki a kiválasztott versenyző nét és életkorát a megfelelő TextBox-okból
        /// A kontroller réteg segítségével törölje a versenyzőt
        /// Ha sikerül a törlés frissítse a versenyző Listbox-ot (updateRacerNameListBox)
        /// Ha a kontroller réteg hibát dob, jelenítse meg a hiba szövegét az errorProviderUpdateRacer segítségével. Biztosítsa az ErrorProvider törlését is!
        /// </summary>
        /// </summary>
        private void buttonDeleteRacer_Click(object sender, EventArgs e)
        {
            errorProviderDeleteRacer.Clear();
            if (listBoxTeam.SelectedIndex < 0)
            {
                errorProviderDeleteRacer.SetError(buttonDeleteRacer, "Ha nincs csapat kijelölve vagy nincs csapat, akkor nem lehet törölni a csapathoz tartozó versenyzőt!");
                return;
            }
            if (listBoxRacer.SelectedIndex < 0)
            {
                errorProviderDeleteRacer.SetError(buttonUpdateRacer, "Ha nincs versenyző kijelölve, akkor nem lehet módosítani a versenyzőjét!");
                return;
            }
            string teamName = listBoxTeam.Text;
            string racerName = textBoxRacerName.Text;
            string racerAge = textBoxRacerAge.Text;
            try
            {
                controller.deleteRacerFromTeam(teamName, racerName, racerAge);
                updateRacerNameListBox(teamName); 
            }
            catch (ControllerException ce)
            {
                errorProviderDeleteRacer.SetError(buttonDeleteRacer, ce.Message);
            }
        }


        /// <summary>
        /// Csapat költségvetés számítás
        /// Ha nincs csapat kijelölve a megfelelő Listbox-ban térjen vissza
        /// Olvassa ki a csapat nevét a ListBox-ból
        /// Számolja ki a kontroller réteg segítségével a csapat költségvetését és jelenítse meg a megfelelő TextBox-ban
        /// </summary>
        private void buttonComputeTeamSalary_Click(object sender, EventArgs e)
        {
            if (listBoxTeam.SelectedIndex < 0)
                return;
            string teamName = listBoxTeam.Text;
            textBoxTeamSalary.Text = controller.computeTeamSalary(teamName);
        }

        /// <summary>
        /// A versenyző átkerül az egyik csapatból a másikba
        /// Ha nincs kijelölve csapat a megfelelő ListBox-ban, akkor nincs csapat amelyikből át lehet hejezni
        /// Ha nincs kijelölve csapat a ComboBox-ban, akkor nincs hova áthejezni
        /// Ha nincs versenyző a megfelelő ListBox-ban, akkor nincs kit áthejezni. Mindhárom esetben térjen vissza
        /// Olvassuk ki a megfelelő ListBox-ból a csapat nevét, a ComboBox-ból a csapat nevet, és a megfelelő ListBox-ból a versenyző nevét
        /// A kontroler réteg segítségével helyezze át a versenyzőt a másik csapatba
        /// Frissítse a versenyzők ListBox-ot (updateRacerNameListBox)
        /// Ha a kontroller réteg hibát dob, jelenítse meg a hiba szövegét az errorProviderMoveToTeam segítségével. Biztosítsa az ErrorProvider törlését is!
        /// </summary>
        private void buttonMoveToTeam_Click(object sender, EventArgs e)
        {
            errorProviderMoveToTeam.Clear();
            if (listBoxTeam.SelectedIndex < 0)
                return;
            if (comboBoxTeamMove.SelectedIndex < 0)
                return;
            if (listBoxRacer.SelectedIndex < 0)
                return;
            string fromTeamName = listBoxTeam.Text;            
            string toTeamName = comboBoxTeamMove.Text;            
            string movedRacerName = listBoxRacer.Text; 
            try
            {
                controller.moveToTeam(fromTeamName, toTeamName, movedRacerName);
                updateRacerNameListBox(fromTeamName);
            }
            catch(ControllerException ce)
            {
                errorProviderMoveToTeam.SetError(buttonMoveToTeam, ce.Message);
            }
        }
    }
}
