using System;
using System.Linq.Expressions;
using System.Reflection;

namespace Learn.Wpf.Common
{
    /// <summary>
    /// A helper class for expressions
    /// </summary>
    public static class ExpressionHelpers
    {
        public static T GetPropertyValue<T>(this Expression<Func<T>> lambda) => lambda.Compile().Invoke();

        public static void SetPropertyValue<T>(this Expression<Func<T>> lambda, T value )
        {
            //converts a lambda () => some.Property to some.Property
            var expression = (lambda as LambdaExpression).Body as MemberExpression;

            //Get the property information so we can set it
            var propertyInfo = (PropertyInfo)expression.Member;
            var target = Expression.Lambda(expression.Expression).Compile().DynamicInvoke();
            propertyInfo.SetValue(target, value);
        }
    }
}