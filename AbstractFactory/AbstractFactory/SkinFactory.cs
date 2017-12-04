namespace AbstractFactory
{
    interface SkinFactory
    {
        Button CreateButton();
        TextField CreateTextField();
        ComboBox CreateComboBox();
    }
}
