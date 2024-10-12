namespace FinancialManagementApp.Shared
{
    public enum RecurrenceTypeEnum
    {
        [RecurrenceTypesInfo("Một lần")]
        OneTime = 1,
        [RecurrenceTypesInfo("Hàng ngày")]
        Daily,
        [RecurrenceTypesInfo("Hàng tuần")]
        Weekly,
        [RecurrenceTypesInfo("Hai tuần một lần")]
        BiWeekly,
        [RecurrenceTypesInfo("Hàng tháng")]
        Monthly,
        [RecurrenceTypesInfo("Hai tháng một lần")]
        BiMonthly,
        [RecurrenceTypesInfo("Hàng quý")]
        Quarterly,
        [RecurrenceTypesInfo("Nửa năm một lần")]
        SemiAnnually,
        [RecurrenceTypesInfo("Hàng năm")]
        Annually,
        [RecurrenceTypesInfo("Tùy chỉnh")]
        Custom
    }
}
