using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Learca
{
    /// <summary>
    /// Форма для вставки в Избранную колоду карточек
    /// </summary>
    class Form_Cards_AddToChosenDeck: Form_Cards_MoveOut
    {
        public Form_Cards_AddToChosenDeck(MainForm mainForm, AbstractDeck targetDeck):base(mainForm,targetDeck)
        {
           
        }

        protected override void Form_Cards_Load(object sender, EventArgs e)
        {
            base.Form_Cards_Load(sender, e);

            Text = "LEARCA. Cards. Add cards to Chosen deck";
            btnMoveOut.Text = "ADD";
        }

        protected override void BtnMoveOut_Click(object sender, EventArgs e)
        {
            if (dataGridView_Cards.SelectedRows.Count == 0)
                throw new Exception("dataGridView_Cards.SelectedRows.Count не может быть = 0");

            var question = (dataGridView_Cards.SelectedRows.Count == 1) ? "Add Card?" : "Add Cards?";

            if (MessageBox.Show(question, "Adding", MessageBoxButtons.YesNo) == DialogResult.No)
                return;

            foreach (DataGridViewRow row in dataGridView_Cards.SelectedRows)
            {
                var card = row.Tag as Card;
                targetDeck.Save(card);
            }

            Database.WriteXml();

            RemoveSelectedRows();

            RefreshButtons();
        }
    }
}
