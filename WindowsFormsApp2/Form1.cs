using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            label5.Text = "Свойства и методы элементов управления";
            label7.Text = "Свойства и методы элементов управления";
            comboBox1.Items.Add("ComboBox");
            CheckBox chbox1 = new CheckBox();
            CheckBox chbox2 = new CheckBox();
            CheckBox chbox3 = new CheckBox();
            chbox1.Text = "НЕТ";
            chbox2.Text = "ДА";
            chbox1.Location = new Point(30, 30);
            chbox2.Location = new Point(30, 60);
            pictureBox1.Image = Image.FromFile("C:\\Users\\dns\\Pictures\\tree.jpg");
        }



        private void button1_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента Button \n" +
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text - Текст на кнопке \n" +
                    "Width - ширина \n" +
                    "Margin Возвращает или задает расстояние между элементами управления. \n" +
                    "TextAlign Возвращает или задает способ выравнивания текста на кнопке.\n" +
                    "... \n" +
                    "Focus() Устанавливает фокус ввода на элемент управления. \n" +
                    "Show() Отображает элемент управления. \n" +
                    "Equals(Object) Определяет, равен ли указанный объект текущему объекту.";




        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            if(maskedTextBox1.Text == "MaskedTextBox")
            {
                label5.Text = "maskedTextBox1_MaskInputRejected";
            }
            
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента ComboBox \n" +
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                    "Items	 Возвращает объект, представляющий коллекцию элементов, содержащихся в данном поле со списком ComboBox. \n" +
                    "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                    "... \n" +
                    "Select() Активирует элемент управления. \n" +
                    "Show() Отображает элемент управления. \n" +
                    "OnMouseClick(MouseEventArgs) Вызывает событие MouseClick. \n" +
                    "FindForm()	Возвращает форму, в которой находится элемент управления. \n";

        }


        private void tabPage1_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента управления TabControl:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Anchor-определяет грани контейнера, к которому привязан определённый элемент управления\n" +
                "3. Margin-определяет отступы между полями элементов\n" +
                "4. HotTrack-указывает, изменяется ли вид вкладок при наведении на них\n" +
                "5. TabPages-число страниц в TabControl\n" +
                "События элемента управления TabControl:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. Selected-происходит после выбора вкладки\n" +
                "3. DrowItem-происходит при необходимости прорисовать элемент/область\n" +
                "4. StyleChanged-событие возникает когда в Control изменяют стиль окна\n" +
                "5. Deselceted-просиходит при отмене выбора вкладки в качестве главной\n";
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label5_Click(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента Label \n" +
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                    "BorderStyle Возвращает или задает стиль границы для элемента управления. \n" +
                    "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                    "... \n" +
                    "Hide() Скрывает элемент управления от пользователя. \n" +
                    "Select() Активирует элемент управления. \n" +
                    "ToString()	Возвращает строку, которая представляет текущий объект Label. \n";


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (textBox1.Text == "TextBox")
            {
                label5.Text = "Свойства и методы элементы TextBox \n" +
                    "Name - имя элемента, по которому можно обращаться в коде \n" +
                    "Text Возвращает или задает текст, связанный с этим элементом управления." +
                    "Size Возвращает или задает высоту и ширину элемента управления. \n" +
                    "BorderStyle Возвращает или задает стиль границы для элемента управления. \n" +
                    "Font Возвращает или задает шрифт текста, отображаемого элементом управления. \n" +
                    "BackColor Возвращает или задает цвет фона элемента управления. \n" +
                    "... \n" +
                    "Clear() Удаляет весь текст из элемента управления 'Текстовое поле'. \n" +
                    "Copy()	Копирует текущий выбор из текстового поля в буфер обмена. \n" +
                    "Cut() Перемещает текущий выбор из текстового поля в буфер обмена. \n" +
                    "Paste() Заменяет текущее выделение в текстовом поле содержимым буфера обмена. \n";

            }
        }



        

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            label5.Text = "Свойства и методы элемента управления CheckBox:\n" +
                "1. Name-имя элемента по которому можно обращаться в коде\n" +
                "2. Text-текст на элементе\n" +
                "3. CheckState-определяет состояние компонента\n" +
                "4. ThreeState-определяет возможность CheckBox использовать 3 состояния вместо 2ух\n" +
                "5. AutoChack-вызывает автоматическое изменение состояния флажка при его выборе\n" +
                "События элемента управления CheckBox:\n" +
                "1. Click-происходит при щелчке элемента управления\n" +
                "2. CheckedChanged-воникает при изменении свойств Check\n" +
                "3. Paint-происходит при перерисовки элемента\n" +
                "4. KeyPress-возникает, когда элемент находится в фокусе и пользоваетль нажимает и отпускает клавишу\n" +
                "5.CheckStateChanged-возникает при изменении свойства CheckState";

        }


        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            if (numericUpDown1.Value > 0)
            {
                label7.Text = "Свойства и методы элемента управления NumericUpDown:\n" +
                    "1. Name-имя элемента по которому можно обращаться в коде\n" +
                    "2. Hexadecimal-указывает должно ли значение числового поля быть в шестнадцатиричном формате\n" +
                    "3. UpDownAlign-прижатие поля со стрелками по X\n" +
                    "4. Maximum-максимальное число\n" +
                    "5. Minimum-минимальное число\n" +
                    "События элемента управления NumericUpDown:\n" +
                    "1. Click-происходит при щелчке элемента управления\n" +
                    "2. Scroll-возникает при перемещении ползунка полосы\n" +
                    "3. ValueChanged-происходит при изменении значения данного элемента\n" +
                    "4. KeyUp-возникает в момент отпускания клавиши\n" +
                    "5. Enter-происходит, когда элемент управления становится активным";
            }
            else { label7.Text = "Свойства и методы элементов управления"; }
        }


        private void tabPage3_Click(object sender, EventArgs e)
        {

        }

        
        private void groupBox1_Enter(object sender, EventArgs e)
        {
            label7.Text = "222222222222222222";
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label7.Text = "3333333333333333333";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label7.Text = "44444444444444444444";
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
            label7.Text = "5555555555555";
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            label7.Text = "666666666666";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label7.Text = "77777777777777777";
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            label7.Text = "888888888888";
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {
            label7.Text = "9999999999999998";
        }

        private void progressBar1_ContextMenuStripChanged(object sender, EventArgs e)
        {
            label7.Text = "1010";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            label7.Text = "8552";
        }
    }
}
