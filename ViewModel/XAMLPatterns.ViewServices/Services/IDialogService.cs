using System;

namespace XAMLPatterns.ViewServices.Services
{
    public interface IDialogService
    {
        bool Prompt(string message);
    }
}
