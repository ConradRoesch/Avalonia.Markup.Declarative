#nullable enable
using Avalonia.Data;
using Avalonia.Data.Converters;
using System;
using System.Linq.Expressions;
using System.Numerics;
using System.Runtime.CompilerServices;

namespace Avalonia.Markup.Declarative;
public static partial class Calendar_MarkupExtensions
{
//================= Properties ======================//
 // FirstDayOfWeekProperty

/*BindFromExpressionSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, Func<System.DayOfWeek> func, Action<System.DayOfWeek>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, System.DayOfWeek value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T FirstDayOfWeek<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T FirstDayOfWeek<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DayOfWeek> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, ps, () => control.FirstDayOfWeek = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // IsTodayHighlightedProperty

/*BindFromExpressionSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, Func<System.Boolean> func, Action<System.Boolean>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, System.Boolean value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T IsTodayHighlighted<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T IsTodayHighlighted<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Boolean> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, ps, () => control.IsTodayHighlighted = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // HeaderBackgroundProperty

/*BindFromExpressionSetterGenerator*/
public static T HeaderBackground<T>(this T control, Func<Avalonia.Media.IBrush> func, Action<Avalonia.Media.IBrush>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T HeaderBackground<T>(this T control, Avalonia.Media.IBrush value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T HeaderBackground<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T HeaderBackground<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.HeaderBackgroundProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T HeaderBackground<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Media.IBrush> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.HeaderBackgroundProperty, ps, () => control.HeaderBackground = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayModeProperty

/*BindFromExpressionSetterGenerator*/
public static T DisplayMode<T>(this T control, Func<Avalonia.Controls.CalendarMode> func, Action<Avalonia.Controls.CalendarMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayMode<T>(this T control, Avalonia.Controls.CalendarMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.CalendarMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayModeProperty, ps, () => control.DisplayMode = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectionModeProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectionMode<T>(this T control, Func<Avalonia.Controls.CalendarSelectionMode> func, Action<Avalonia.Controls.CalendarSelectionMode>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectionMode<T>(this T control, Avalonia.Controls.CalendarSelectionMode value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectionMode<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectionMode<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectionModeProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectionMode<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, Avalonia.Controls.CalendarSelectionMode> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectionModeProperty, ps, () => control.SelectionMode = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // SelectedDateProperty

/*BindFromExpressionSetterGenerator*/
public static T SelectedDate<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T SelectedDate<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T SelectedDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T SelectedDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.SelectedDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T SelectedDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.SelectedDateProperty, ps, () => control.SelectedDate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayDateProperty

/*BindFromExpressionSetterGenerator*/
public static T DisplayDate<T>(this T control, Func<System.DateTime> func, Action<System.DateTime>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDate<T>(this T control, System.DateTime value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDate<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDate<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDate<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.DateTime> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateProperty, ps, () => control.DisplayDate = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayDateStartProperty

/*BindFromExpressionSetterGenerator*/
public static T DisplayDateStart<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDateStart<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDateStart<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDateStart<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateStartProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDateStart<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateStartProperty, ps, () => control.DisplayDateStart = converter.TryConvert(value), bindingMode, converter, bindingSource);


 // DisplayDateEndProperty

/*BindFromExpressionSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, Func<System.Nullable<System.DateTime>> func, Action<System.Nullable<System.DateTime>>? onChanged = null, [CallerArgumentExpression("func")] string? expression = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, func, onChanged, expression);

/*MagicalSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, System.Nullable<System.DateTime> value, BindingMode? bindingMode = null, IValueConverter? converter = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = value, bindingMode, converter, bindingSource);

/*BindSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, IBinding binding) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);

/*AvaloniaPropertyBindSetterGenerator*/
public static T DisplayDateEnd<T>(this T control, AvaloniaProperty avaloniaProperty, BindingMode? bindingMode = null, IValueConverter? converter = null, ViewBase? overrideView = null) where T : Avalonia.Controls.Calendar
   => control._set(Avalonia.Controls.Calendar.DisplayDateEndProperty, avaloniaProperty, bindingMode, converter, overrideView);

/*MagicalSetterWithConverterGenerator*/
public static T DisplayDateEnd<T,TValue>(this T control, TValue value, FuncValueConverter<TValue, System.Nullable<System.DateTime>> converter, BindingMode? bindingMode = null, object? bindingSource = null, [CallerArgumentExpression("value")] string? ps = null) where T : Avalonia.Controls.Calendar
=> control._setEx(Avalonia.Controls.Calendar.DisplayDateEndProperty, ps, () => control.DisplayDateEnd = converter.TryConvert(value), bindingMode, converter, bindingSource);



//================= Events ======================//
 // SelectedDatesChanged

/*ActionToEventGenerator*/
    public static T OnSelectedDatesChanged<T>(this T control, Action<Avalonia.Controls.SelectionChangedEventArgs> action) where T : Avalonia.Controls.Calendar => 
        control._setEvent((System.EventHandler<Avalonia.Controls.SelectionChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.SelectedDatesChanged += h);


 // DisplayDateChanged

/*ActionToEventGenerator*/
    public static T OnDisplayDateChanged<T>(this T control, Action<Avalonia.Controls.CalendarDateChangedEventArgs> action) where T : Avalonia.Controls.Calendar => 
        control._setEvent((System.EventHandler<Avalonia.Controls.CalendarDateChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DisplayDateChanged += h);


 // DisplayModeChanged

/*ActionToEventGenerator*/
    public static T OnDisplayModeChanged<T>(this T control, Action<Avalonia.Controls.CalendarModeChangedEventArgs> action) where T : Avalonia.Controls.Calendar => 
        control._setEvent((System.EventHandler<Avalonia.Controls.CalendarModeChangedEventArgs>) ((arg0, arg1) => action(arg1)), h => control.DisplayModeChanged += h);



//================= Styles ======================//
 // FirstDayOfWeekProperty

/*ValueStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, System.DayOfWeek value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> FirstDayOfWeek<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.FirstDayOfWeekProperty, binding);


 // IsTodayHighlightedProperty

/*ValueStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, System.Boolean value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> IsTodayHighlighted<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.IsTodayHighlightedProperty, binding);


 // HeaderBackgroundProperty

/*ValueStyleSetterGenerator*/
public static Style<T> HeaderBackground<T>(this Style<T> style, Avalonia.Media.IBrush value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> HeaderBackground<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.HeaderBackgroundProperty, binding);


 // DisplayModeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, Avalonia.Controls.CalendarMode value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayModeProperty, binding);


 // SelectionModeProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, Avalonia.Controls.CalendarSelectionMode value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectionMode<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectionModeProperty, binding);


 // SelectedDateProperty

/*ValueStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> SelectedDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.SelectedDateProperty, binding);


 // DisplayDateProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, System.DateTime value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDate<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateProperty, binding);


 // DisplayDateStartProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateStart<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateStartProperty, binding);


 // DisplayDateEndProperty

/*ValueStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, System.Nullable<System.DateTime> value) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, value);

/*BindingStyleSetterGenerator*/
public static Style<T> DisplayDateEnd<T>(this Style<T> style, IBinding binding) where T : Avalonia.Controls.Calendar
=> style._addSetter(Avalonia.Controls.Calendar.DisplayDateEndProperty, binding);



}