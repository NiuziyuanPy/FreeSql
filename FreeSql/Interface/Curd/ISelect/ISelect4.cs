﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace FreeSql {
	public interface ISelect<T1, T2, T3, T4> : ISelect0<ISelect<T1, T2, T3, T4>, T1> where T1 : class where T2 : class where T3 : class where T4 : class {

		List<TReturn> ToList<TReturn>(Expression<Func<T1, T2, T3, T4, TReturn>> select);

		TMember Sum<TMember>(Expression<Func<T1, T2, T3, T4, TMember>> column);
		TMember Min<TMember>(Expression<Func<T1, T2, T3, T4, TMember>> column);
		TMember Max<TMember>(Expression<Func<T1, T2, T3, T4, TMember>> column);
		TMember Avg<TMember>(Expression<Func<T1, T2, T3, T4, TMember>> column);

		ISelect<T1, T2, T3, T4> Where(Expression<Func<T1, T2, T3, T4, bool>> exp);
		ISelect<T1, T2, T3, T4> WhereIf(bool condition, Expression<Func<T1, T2, T3, T4, bool>> exp);

		ISelect<T1, T2, T3, T4> WhereLike(Expression<Func<T1, T2, T3, T4, string[]>> columns, string pattern, bool notLike = false);
		ISelect<T1, T2, T3, T4> WhereLike(Expression<Func<T1, T2, T3, T4, string>> column, string pattern, bool notLike = false);

		ISelect<T1, T2, T3, T4> GroupBy(Expression<Func<T1, T2, T3, T4, object>> columns);

		ISelect<T1, T2, T3, T4> OrderBy<TMember>(Expression<Func<T1, T2, T3, T4, TMember>> column);
		ISelect<T1, T2, T3, T4> OrderByDescending<TMember>(Expression<Func<T1, T2, T3, T4, TMember>> column);
	}
}