using FluentValidation;
using SupportApp.Project;

namespace SupportApp.Validators;

public class ProjectCreateValidator : AbstractValidator<CreateProjectDTO>
{
    public ProjectCreateValidator()
    {
        RuleFor(x => x.Name)
            .NotEmpty().WithMessage(FrequenceMessage.EmptyMessage)
            .MaximumLength(50).WithMessage("Name must not exceed 50 characters").NotNull().WithMessage(FrequenceMessage.EmptyMessage);
    }
}
