﻿using System.Collections.Generic;
using System.IO;

namespace Kingdom.OrTools.ConstraintSolver.Samples.Sudoku
{
    /// <summary>
    /// Sudoku puzzle interface.
    /// </summary>
    public interface ISudokuPuzzle
    {
        /// <summary>
        /// Returns whether IsSolved.
        /// </summary>
        bool IsSolved { get; }

        /// <summary>
        /// Gets the Rows from the puzzle.
        /// </summary>
        IEnumerable<IDictionary<Address, int>> Rows { get; }

        /// <summary>
        /// Gets the Columns from the puzzle.
        /// </summary>
        IEnumerable<IDictionary<Address, int>> Columns { get; }

        /// <summary>
        /// Gets the Blocks from the puzzle.
        /// </summary>
        IEnumerable<IDictionary<Address, int>> Blocks { get; }

        /// <summary>
        /// Gets the Matrix Values.
        /// </summary>
        int[,] Values { get; }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        int this[Address key] { get; set; }

        /// <summary>
        /// Indexer
        /// </summary>
        /// <param name="row"></param>
        /// <param name="column"></param>
        /// <returns></returns>
        int this[int row, int column] { get; set; }

        /// <summary>
        /// Writes the puzzle to the writer.
        /// </summary>
        /// <param name="writer"></param>
        void PrettyPrint(TextWriter writer);
    }
}
