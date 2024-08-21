using System.Xml.XPath;

namespace ExchangeRate
{
	public partial class Form1 : Form
	{
		private readonly AutoCompleteStringCollection currencyNames = new AutoCompleteStringCollection()
		{
			"Австралійський долар", "Канадський долар", "Юань Женьміньбі", "Чеська крона",
			"Данська крона", "Гонконгівський долар", "Форинт", "Індійська рупія", "Рупія",
			"Новий ізраїльський шекель", "Єна", "Теньге", "Вона", "Мексиканське песо",
			"Молдовський лей", "Новозеландський долар", "Норвезька крона", "Російський рубль",
			"Сінгапурський долар", "Ренд", "Шведська крона", "Швейцарський франк", "Єгипетський фунт",
			"Фунт стерлінгів", "Долар США", "Білоруський рубль", "Азербайджанський манат",
			"Румунський лей", "Турецька ліра", "СПЗ (спеціальні права запозичення)", "Болгарський лев",
			"Євро", "Злотий", "Алжирський динар", "Така", "Вірменський драм", "Домініканське песо",
			"Іранський ріал", "Іракський динар", "Сом", "Ліванський фунт", "Лівійський динар",
			"Малайзійський ринггіт", "Марокканський дирхам", "Пакистанська рупія", "Саудівський ріял",
			"Донг", "Бат", "Дирхам ОАЕ", "Туніський динар", "Узбецький сум", "Новий тайванський долар",
			"Туркменський новий манат", "Сербський динар", "Сомоні", "Ларі", "Бразильський реал",
			"Золото", "Срібло", "Платина", "Паладій"
		};

		public Form1()
		{
			InitializeComponent();
			ConfigureAutoComplete();
		}

		private void ConfigureAutoComplete()
		{
			inputCurrency.AutoCompleteCustomSource = currencyNames;
			inputCurrency.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			inputCurrency.AutoCompleteSource = AutoCompleteSource.CustomSource;
		}

		private void CalculateCurrency()
		{
			if (!ValidateInput())
			{
				return;
			}

			try
			{
				var exchangeRate = GetExchangeRate();
				if (exchangeRate.HasValue)
				{
					label2.Text = $"{Convert.ToDecimal(inputUAH.Text) / exchangeRate.Value.rate} {exchangeRate.Value.shortName}";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка завантаження або аналізу XML файлу: {ex.Message}");
			}
		}

		private void DownloadCurrencyInfo()
		{
			if (!ValidateInput())
			{
				return;
			}

			try
			{
				var exchangeRate = GetExchangeRate();
				if (exchangeRate.HasValue)
				{
					label4.Text = $"Курс валюти завантажено з офційного сайту:\n" +
						$"https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange\n" +
						$"{exchangeRate.Value.currencyName}, {exchangeRate.Value.shortName}, курс - {exchangeRate.Value.rate}, дата {exchangeRate.Value.date}";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"Помилка завантаження або аналізу XML файлу: {ex.Message}");
			}
		}

		private bool ValidateInput()
		{
			if (!currencyNames.Contains(inputCurrency.Text))
			{
				MessageBox.Show("Виберіть справжню валюту!");
				return false;
			}

			if (string.IsNullOrEmpty(inputUAH.Text))
			{
				MessageBox.Show("Введіть суму!");
				return false;
			}

			return true;
		}

		private (string currencyName, string shortName, decimal rate, DateTime date)? GetExchangeRate()
		{
			var xPathDoc = new XPathDocument("https://bank.gov.ua/NBUStatService/v1/statdirectory/exchange");
			var xPathDocNavigator = xPathDoc.CreateNavigator();
			var exchangeRateNode = xPathDocNavigator?.SelectSingleNode($"/exchange/currency[txt='{inputCurrency.Text}']");

			if (exchangeRateNode == null)
			{
				return null;
			}

			string currencyName = exchangeRateNode.SelectSingleNode("txt")?.Value ?? "";
			string shortName = exchangeRateNode.SelectSingleNode("cc")?.Value ?? "";
			decimal rate = decimal.Parse(exchangeRateNode.SelectSingleNode("rate")?.Value.Replace(".", ",") ?? "0");
			DateTime date = DateTime.Parse(exchangeRateNode.SelectSingleNode("exchangedate")?.Value ?? DateTime.MinValue.ToString());

			return (currencyName, shortName, rate, date);
		}

		private void infoButton_Click(object sender, EventArgs e)
		{
			DownloadCurrencyInfo();
		}

		private void calculateButton_Click(object sender, EventArgs e)
		{
			CalculateCurrency();
		}

		private void closeButton_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
