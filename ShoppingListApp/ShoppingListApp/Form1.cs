namespace ShoppingListApp
{
    public partial class Form1 : Form
    {
        string[] units = ["cm", "g", "kg", "lit", "m"];
        List<string> shoppingList = [];
        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult userResponse = MessageBox.Show("Do you want to exit the application?",
                "Leave Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (userResponse == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboUnits.Items.AddRange(units);

            lbxShoppingList.DataSource = shoppingList;
        }

        private void UpdateGUI()
        {
            lbxShoppingList.DataSource = null;
            lbxShoppingList.DataSource = shoppingList;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string item = tbxItem.Text;
            string unit = comboUnits.SelectedItem.ToString();

            double amount;
            bool amountOk = double.TryParse(tbxAmount.Text, out amount);

            if (!string.IsNullOrEmpty(item) &&
                !string.IsNullOrEmpty(unit) && amountOk)
            {
                string row = $"{item}\t\t{amount} {unit}";
                shoppingList.Add(row);
                UpdateGUI();
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "You must provide the following: description, amount, unit";
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            int index = lbxShoppingList.SelectedIndex;

            if (index != -1)
            {
                DialogResult deleteConfirmation = MessageBox.Show("Do you want to remove the item?",
                "Remove item", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (deleteConfirmation == DialogResult.Yes)
                {
                    shoppingList.RemoveAt(index);
                    UpdateGUI();
                }
            }
            else
            {
                lblError.Visible = true;
                lblError.Text = "You need to select an item to delete.";
            }
        }

        private void lbxShoppingList_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblError.Visible = false;
            lblError.Text = string.Empty;
        }
    }
}
