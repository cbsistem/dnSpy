﻿/*
    Copyright (C) 2014-2016 de4dot@gmail.com

    This file is part of dnSpy

    dnSpy is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    dnSpy is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with dnSpy.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;

namespace dnSpy.Contracts.Command {
	/// <summary>
	/// Handles commands
	/// </summary>
	public interface ICommandTargetFilter : IDisposable {
		/// <summary>
		/// Executes the command
		/// </summary>
		/// <param name="target">Target object</param>
		/// <param name="group">Command group, eg. <see cref="CommandConstants.DefaultGroup"/></param>
		/// <param name="cmdId">Command ID</param>
		/// <param name="args">Arguments or null</param>
		/// <param name="result">Updated with the result</param>
		/// <returns></returns>
		CommandTargetStatus Execute(object target, Guid group, int cmdId, object args, ref object result);

		/// <summary>
		/// Checks whether the command can execute. If it can execute, it must return <see cref="CommandTargetStatus.Handled"/>
		/// </summary>
		/// <param name="target">Target object</param>
		/// <param name="group">Command group, eg. <see cref="CommandConstants.DefaultGroup"/></param>
		/// <param name="cmdId">Command ID</param>
		/// <returns></returns>
		CommandTargetStatus CanExecute(object target, Guid group, int cmdId);
	}
}