using Microsoft.EntityFrameworkCore;
using Pr3_3_Up_Uporov.Models;
using Pr3_3_Up_Uporov.Properties;
using User = Pr3_3_Up_Uporov.Models.User;

namespace Pr3_3_Up_Uporov
{
    public partial class FormTovars : Form
    {
        public User CurrentUser { get; private set; }
        public bool IsGuest { get; private set; }

        public FormTovars(User user, bool guest)
        {
            InitializeComponent();

            var colPhoto = new DataGridViewImageColumn();
            colPhoto.Name = "colPhoto";
            colPhoto.ImageLayout = DataGridViewImageCellLayout.Zoom;
            colPhoto.Width = 200;
            colPhoto.FillWeight = 30;

            var colInfo = new DataGridViewTextBoxColumn();
            colInfo.Name = "colInfo";
            colInfo.FillWeight = 60;
            colInfo.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

            var colDiscount = new DataGridViewTextBoxColumn();
            colDiscount.Name = "colDiscount";
            colDiscount.FillWeight = 10;
            colDiscount.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvTovars.Columns.AddRange(
            [
                colPhoto, colInfo, colDiscount
            ]);

            //dgvTovars.CellFormatting += DgvTovars_CellFormatting;

            CurrentUser = user;
            IsGuest = guest;

            lblUserName.Text = IsGuest ? "Гость" : CurrentUser.UserFio;

            LoadTovars();
        }

        private void LoadTovars()
        {
            try
            {
                using (var db = new StoreSportUporovContext())
                {
                    var tovars = db.SportTovars
                        .Include(i => i.Category)
                        .Include(i => i.Category)
                        .Include(i => i.Manufacture)
                        .Include(i => i.Suplier)
                        .ToList();

                    dgvTovars.SuspendLayout();
                    dgvTovars.Rows.Clear();

                    foreach (var product in tovars)
                    {
                        int rowIndex = dgvTovars.Rows.Add();
                        var row = dgvTovars.Rows[rowIndex];

                        row.Cells["colPhoto"].Value = LoadTovarImage(product.Photo);
                        row.Cells["colInfo"].Value = FormatTovarInfo(product);
                        row.Cells["colDiscount"].Value = $"{product.Discount}%";
                        row.Cells["colDiscount"].Style.Alignment = DataGridViewContentAlignment.MiddleCenter;

                        // Сохраняем объект товара в тег строки для использования при форматировании
                        row.Tag = product;

                        ApplyRowStyles(row, product);
                    }

                    dgvTovars.ResumeLayout();
                    dgvTovars.AutoResizeRows(DataGridViewAutoSizeRowsMode.AllCells);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка загрузки: {ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApplyRowStyles(DataGridViewRow row, SportTovar tovar)
        {
            // Сначала проверяем наличие товара на складе - это наивысший приоритет
            if (tovar.QuantityInStock <= 0)
            {
                row.DefaultCellStyle.BackColor = Color.LightBlue;
                row.DefaultCellStyle.ForeColor = Color.Black;
                // Для товаров не в наличии другие стили не применяем
                return;
            }

            // Затем проверяем скидку больше 15%
            if (tovar.Discount > 15)
            {
                row.DefaultCellStyle.BackColor = ColorTranslator.FromHtml("#2E8B57");
                row.DefaultCellStyle.ForeColor = Color.White;
            }
            else
            {
                // Сбрасываем фон, если не подходит под условия
                row.DefaultCellStyle.BackColor = Color.White;
                row.DefaultCellStyle.ForeColor = Color.Black;
            }

            // Оформление ячейки со скидкой
            if (tovar.Discount > 0)
            {
                row.Cells["colDiscount"].Style.ForeColor = Color.Red;
                row.Cells["colDiscount"].Style.Font = new Font(
                    "Times New Roman",
                    12,
                    FontStyle.Bold);
            }
            else
            {
                // Сбрасываем стиль скидки, если скидки нет
                row.Cells["colDiscount"].Style.ForeColor = Color.Black;
                row.Cells["colDiscount"].Style.Font = new Font(
                    "Times New Roman",
                    12,
                    FontStyle.Regular);
            }
        }

        private string FormatTovarInfo(SportTovar tovar)
        {
            string priceText;

            if (tovar.Discount > 0)
            {
                decimal finalPrice = (decimal)(tovar.Price * (100 - tovar.Discount) / 100);
                priceText = $"Цена: {tovar.Price:C} -> {finalPrice:C} ";
            }
            else
            {
                priceText = $"Цена: {tovar.Price:C}";
            }

            return $"Категория: {tovar.Category.CategoryName}" + Environment.NewLine +
                $"Описание товара: {tovar.Description}" + Environment.NewLine +
                $"Производитель: {tovar.Manufacture.ManufacturesName}" + Environment.NewLine +
                $"Поставщик: {tovar.Suplier.SupliersName}" + Environment.NewLine +
                $"{priceText}" + Environment.NewLine +
                $"Количество на складе: {tovar.QuantityInStock}" + Environment.NewLine;
        }

        //private void DgvTovars_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        //{
        //    // Дополнительное форматирование для ячейки с информацией
        //    //if (dgvTovars.Columns[e.ColumnIndex].Name == "colInfo" && e.Value != null)
        //    //{
        //    //    // Здесь можно добавить дополнительное форматирование, 
        //    //    // если DataGridView поддерживает HTML-форматирование
        //    //}
        //}

        private Image LoadTovarImage(string photoUrl)
        {
            try
            {
                if (!string.IsNullOrWhiteSpace(photoUrl))
                {
                    string fileName = System.IO.Path.GetFileNameWithoutExtension(photoUrl);

                    // Пытаемся загрузить из ресурсов
                    var resourceProperty = Resources.ResourceManager.GetObject(fileName) as Image;
                    if (resourceProperty != null)
                    {
                        return resourceProperty;
                    }

                    // Если не нашли в ресурсах, пробуем загрузить из файла
                    if (System.IO.File.Exists(photoUrl))
                    {
                        return Image.FromFile(photoUrl);
                    }
                }

                // Возвращаем картинку-заглушку
                return Resources.picture;
            }
            catch
            {
                return Resources.picture;
            }
        }

        private void BtnLogut_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}