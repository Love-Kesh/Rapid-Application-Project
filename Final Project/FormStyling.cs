using System;
using System.Drawing;
using System.Windows.Forms;

namespace Final_Project
{
    // Shared class to apply styling to all the forms
    public static class FormStyling
    {
        // Define colors for the app's color pallete
        private static readonly Color BlueGray = ColorTranslator.FromHtml("#90adc6");
        private static readonly Color Pewter = ColorTranslator.FromHtml("#e9eaec");
        private static readonly Color Yellow = ColorTranslator.FromHtml("#fad02c");
        private static readonly Color DarkBlue = ColorTranslator.FromHtml("#333652");

        public static void ApplyFormStyling(Form form)
        {
            form.BackColor = Pewter;

            foreach (var control in form.Controls)
            {
                if (control is Button button)
                {
                    ApplyButtonStyling(button);
                }
                else if (control is Label label)
                {
                    ApplyLabelStyling(label);
                }
                else if (control is DataGridView dataGridView)
                {
                    ApplyDataGridViewStyling(dataGridView);
                }
                else if (control is ComboBox comboBox)
                {
                    ApplyComboBoxStyling(comboBox);
                }
                else if (control is TextBox textBox)
                {
                    ApplyTextBoxStyling(textBox);
                }
            }
        }

        // Button styling
        public static void ApplyButtonStyling(Button button)
        {
            button.BackColor = BlueGray;
            button.ForeColor = Color.White;
            button.FlatStyle = FlatStyle.Flat;
            button.Font = new Font("Arial", 10, FontStyle.Bold);
        }

        // DataGridView styling
        public static void ApplyDataGridViewStyling(DataGridView dataGridView)
        {
            dataGridView.BackgroundColor = Pewter;
            dataGridView.BorderStyle = BorderStyle.None;
            dataGridView.Font = new Font("Arial", 10);
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = DarkBlue;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);
            dataGridView.DefaultCellStyle.SelectionBackColor = Yellow;
            dataGridView.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        // TextBox styling
        public static void ApplyTextBoxStyling(TextBox textBox)
        {
            textBox.BackColor = Color.White;
            textBox.Font = new Font("Arial", 10);
        }

        // ComboBox styling
        public static void ApplyComboBoxStyling(ComboBox comboBox)
        {
            comboBox.BackColor = Pewter;
            comboBox.Font = new Font("Arial", 10);
        }

        // Label styling
        public static void ApplyLabelStyling(Label label)
        {
            label.Font = new Font("Arial", 12, FontStyle.Bold);
            label.ForeColor = DarkBlue;
        }
    }
}
