using System.Collections.ObjectModel;
using System.Globalization;

namespace iOSCarouselStuck;

public partial class MainPage : ContentPage
{
	static readonly List<Enum> _TestEnums = new()
	{
		TestEnum.Value1,
		TestEnum.Value2,
		TestEnum.Value3
	};
    static readonly List<string> _TestStrings = new()
	{
		"Value1",
		"Value2",
		"Value3"
	};

	public List<Enum> TestEnums { get; } = _TestEnums;
	public ObservableCollection<string> TestStrings { get; } = new ObservableCollection<string>(_TestStrings);

	public MainPage()
	{
		InitializeComponent();
	}
}

public enum TestEnum
{
	Value1,
	Value2,
	Value3
}
