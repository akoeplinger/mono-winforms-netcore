using System;
using System.Globalization;

namespace System.Reflection
{
    public interface IReflect
    {
        MethodInfo GetMethod(String name, BindingFlags bindingAttr, Binder binder,
                Type[] types, ParameterModifier[] modifiers);

        MethodInfo GetMethod(String name, BindingFlags bindingAttr);

        MethodInfo[] GetMethods(BindingFlags bindingAttr);

        FieldInfo GetField(
                String name,
                BindingFlags bindingAttr);

        FieldInfo[] GetFields(
                BindingFlags bindingAttr);

        PropertyInfo GetProperty(
                String name,
                BindingFlags bindingAttr);

        PropertyInfo GetProperty(
                String name,
                BindingFlags bindingAttr,
                Binder binder,
                Type returnType,
                Type[] types,
                ParameterModifier[] modifiers);

        PropertyInfo[] GetProperties(
                BindingFlags bindingAttr);

        MemberInfo[] GetMember(
                String name,
                BindingFlags bindingAttr);

        MemberInfo[] GetMembers(
                BindingFlags bindingAttr);

        Object InvokeMember(
                String name,
                BindingFlags invokeAttr,
                Binder binder,
                Object target,
                Object[] args,
                ParameterModifier[] modifiers,
                CultureInfo culture,
                String[] namedParameters);

        Type UnderlyingSystemType
        {
            get;
        }

    }
}