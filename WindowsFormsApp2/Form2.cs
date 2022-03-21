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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
        public Form2(Form1 f)
        {
            InitializeComponent();
            f.BackColor = Color.LightSeaGreen;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "СВОЙСТВА ФОРМЫ\n" +
                "Name: устанавливает имя формы\n" +
                "BackColor: указывает на фоновый цвет формы\n" +
                "BackgroundImage: позволяет установить фоновое изображение формы\n" +
                "ControlBox: указывает, отображается ли меню формы(меню верхнего уровня)\n" +
                "Cursor: определяет тип курсора, который используется на форме\n" +
                "Font: задает шрифт для формы и её элементов\n" +
                "ForeColor: цвет шрифта на форме\n" +
                "StartPosition: указывает на начальную позицию, с которой форма появляется на экране\n" +
                "Text: определяет заголовок формы\n" +
                "TopMost: при значении true означает что форма всегда будет находиться поверх других окон\n" +
                "Size: определяет начальный размер формы";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = "МЕТОДЫ ФОРМЫ\n" +
                "Close()	Закрывает форму\n" +
                "ScaleCore(Single, Single)	Выполняет масштабирование формы\n" +
                "Select()	Активирует элемент управления\n" +
                "Select()	Активирует элемент управления\n" +
                "CenterToScreen()	Выравнивает форму по центру текущего экрана\n" +
                "Dispose(Boolean)	Уничтожает ресурсы(кроме памяти), используемые классом Form";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = "СВЯЗЬ МЕЖДУ ФОРМАМИ\n" +
                "1)Добавить еще одну форму в проект можно в окне Solution Explorer (Обозреватель решений)\n" +
                "2)1ая форма может воздействовать на 2ую форму, например, открывать ее по нажатию кнопки\n" +
                "Тогда, в обработчик события нажатия кнопки, который создается по умолчанию\n" +
                "после двойного щелчка по кнопке в конструкторе формы, нужно добавить код вызова 2ой формы\n" +
                "3)И наоборот, 2ая форма может воздействовать на 1ую. Для этого нужно воспользоваться\n" +
                "передачей ссылки на форму в конструкторе. Например, можно добавить в код 2ой формы новый\n" +
                "конструктор public Form2(Form1 f), в котором мы получаем 1ую форму и меняем цвет ее фона.\n" +
                "4)При работе с несколькими формами надо учитывать, что одна из них является главной\n" +
                "Если у нас одновременно открыто несколько форм, то при закрытии главной, закрывается\n" +
                "закрывается все приложение и вместе с ним все остальные формы.";
        }
    }
}
