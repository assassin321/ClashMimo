namespace ClashMimo.Presentation.ViewModels;

public sealed record ConnectionDetailGroupViewModel(
    string Title,
    IReadOnlyList<ConnectionDetailRowViewModel> Rows);
