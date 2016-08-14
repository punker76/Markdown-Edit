﻿using System.Windows;
using System.Windows.Input;
using MarkdownEdit.Controls;
using MarkdownEdit.Models;

namespace MarkdownEdit.Commands
{
    internal static class OpenFileCommand
    {
        public static readonly RoutedCommand Command = ApplicationCommands.Open;

        static OpenFileCommand()
        {
            Application.Current.MainWindow.CommandBindings.Add(new CommandBinding(Command, Execute));
        }

        private static void Execute(object sender, ExecutedRoutedEventArgs e)
        {
            var mainWindow = (MainWindow)sender;
            EditorLoadSave.OpenFile(mainWindow.Editor, e.Parameter as string);
        }
    }
}