using Avalonia.Controls;
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class ContextMenuEventsExtensions
{
    public static ContextMenu OnOpening(this ContextMenu control, Action action) => 
        control._setEvent((CancelEventHandler) ((_, args) => action()), h => control.Opening += h);
    public static ContextMenu OnClosing(this ContextMenu control, Action action) => 
        control._setEvent((CancelEventHandler) ((_, args) => action()), h => control.Closing += h);
}

