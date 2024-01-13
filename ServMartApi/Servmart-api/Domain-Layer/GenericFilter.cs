using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Reflection;
using System.Threading.Tasks;

namespace Domain_Layer.Helpers
{
    public class GenericFilter<T>
    {
        public IQueryable<T> ApplyFilter(IQueryable<T> query, FilterModel<T> filters)
        {
            if (filters == null)
            {
                return query;
            }

            var parameter = Expression.Parameter(typeof(T), "x");
            var predicate = BuildPredicate(parameter, filters);

            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            return query;
        }

        private Expression<Func<T, bool>> BuildPredicate(ParameterExpression parameter, FilterModel<T> filters)
        {
            Expression finalExpression = null;

            foreach (var filter in filters.FilterExpressions)
            {
                var property = typeof(T).GetProperty(filter.PropertyName);    
                PropertyInfo propertyinfo = typeof(T).GetProperty(filter.PropertyName);
                var type = propertyinfo.PropertyType;
                var left = Expression.Property(parameter, property);
                Expression right = null ;
                if (propertyinfo.PropertyType == typeof(string))
                    right = Expression.Constant(filter.Value.ToString(), property.PropertyType);
                else if (propertyinfo.PropertyType == typeof(decimal))
                    right = Expression.Constant(decimal.Parse(filter.Value.ToString()), property.PropertyType);
                else if (propertyinfo.PropertyType == typeof(int))
                    right = Expression.Constant(int.Parse(filter.Value.ToString()), property.PropertyType);

                if (right == null)
                    return null;
                var equality = Expression.Equal(left, right);

                if (finalExpression == null)
                {
                    finalExpression = equality;
                }
                else
                {
                    finalExpression = Expression.AndAlso(finalExpression, equality);
                }
            }

            return finalExpression != null ? Expression.Lambda<Func<T, bool>>(finalExpression, parameter) : null;
        }
    }

    public class FilterModel<T>
    {
        public List<FilterExpression<T>> FilterExpressions { get; set; }
    }

    public class FilterExpression<T>
    {
        public string PropertyName { get; set; }
        public object Value { get; set; }
    }
}
