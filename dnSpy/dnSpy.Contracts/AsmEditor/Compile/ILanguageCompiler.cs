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
using System.Threading;
using System.Threading.Tasks;

namespace dnSpy.Contracts.AsmEditor.Compile {
	/// <summary>
	/// Compiles source code
	/// </summary>
	public interface ILanguageCompiler : IDisposable {
		/// <summary>
		/// Called after the code has been decompiled
		/// </summary>
		/// <param name="decompiledCodeResult">Decompiled code</param>
		void AddDecompiledCode(IDecompiledCodeResult decompiledCodeResult);

		/// <summary>
		/// Gets all code documents. Called after <see cref="AddDecompiledCode(IDecompiledCodeResult)"/>
		/// has been called.
		/// </summary>
		/// <param name="mainDocument">Main document</param>
		/// <returns></returns>
		ICodeDocument[] GetCodeDocuments(out ICodeDocument mainDocument);

		/// <summary>
		/// Compiles the code
		/// </summary>
		/// <param name="cancellationToken">Cancellation token</param>
		/// <returns></returns>
		Task<CompilationResult> CompileAsync(CancellationToken cancellationToken);

		/// <summary>
		/// Adds new metadata references. Called after <see cref="AddDecompiledCode(IDecompiledCodeResult)"/>
		/// has been called.
		/// </summary>
		/// <param name="metadataReferences">Metadata references</param>
		/// <returns></returns>
		bool AddMetadataReferences(CompilerMetadataReference[] metadataReferences);
	}
}