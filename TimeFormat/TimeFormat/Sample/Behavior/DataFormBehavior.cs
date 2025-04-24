using Syncfusion.Maui.DataForm;

namespace TimeFormat
{
    public class DataFormBehavior : Behavior<SfDataForm>
    {
        protected override void OnAttachedTo(SfDataForm dataForm)
        {
            base.OnAttachedTo(dataForm);
            if (dataForm != null )
            {
                dataForm.ItemsSourceProvider = new ItemSourceProvider();
                dataForm.RegisterEditor("Gender", DataFormEditorType.RadioGroup);
                dataForm.RegisterEditor("Event", DataFormEditorType.ComboBox);
                dataForm.GenerateDataFormItem += OnGenerateDataFormItem;
            }
        }
        private void OnGenerateDataFormItem(object? sender, GenerateDataFormItemEventArgs e)
        {
            if (e.DataFormItem!= null)
            {
                if (e.DataFormItem.FieldName == "EventTime" && e.DataFormItem is DataFormTimeItem timeItem)
                {
                    timeItem.Format = "HH:mm";
                }
            }
        }
        protected override void OnDetachingFrom(SfDataForm dataForm)
        {
            base.OnDetachingFrom(dataForm);
            if (dataForm != null)
            {
                dataForm.GenerateDataFormItem -= OnGenerateDataFormItem;
            }
        }
    }
}