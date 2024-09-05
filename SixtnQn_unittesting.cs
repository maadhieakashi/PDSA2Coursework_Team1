using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PDSA2Coursework_Team1;

namespace PDSA2Coursework_Team1.Tests
{
    [TestClass]
    public class SixtnQn_unittesting
    {
        private SixteenQueen_Puzzle sixteenQueenPuzzle;
        private DatabaseManager dbManager;

        [TestInitialize]
        public void Setup()
        {
            sixteenQueenPuzzle = new SixteenQueen_Puzzle();
            dbManager = new DatabaseManager();
        }

        [TestMethod]
        public void Test_IsWithinBoard()
        {
            Assert.IsTrue(sixteenQueenPuzzle.IsWithinBoard(0, 0));
            Assert.IsTrue(sixteenQueenPuzzle.IsWithinBoard(15, 15));
            Assert.IsFalse(sixteenQueenPuzzle.IsWithinBoard(16, 16));
            Assert.IsFalse(sixteenQueenPuzzle.IsWithinBoard(-1, 0));
        }

        [TestMethod]
        public void Test_CanPlaceQueen()
        {
            Assert.IsTrue(sixteenQueenPuzzle.CanPlaceQueen(0, 0)); // Empty board, can place queen
            Assert.IsFalse(sixteenQueenPuzzle.CanPlaceQueen(0, 0)); // Queen already placed
        }

        [TestMethod]
        public void Test_ToggleQueen()
        {
            sixteenQueenPuzzle.ToggleQueen(0, 0);
            Assert.IsTrue(sixteenQueenPuzzle.CanPlaceQueen(0, 0)); 
            sixteenQueenPuzzle.ToggleQueen(0, 0);
            Assert.IsFalse(sixteenQueenPuzzle.CanPlaceQueen(0, 0)); 
        }

        [TestMethod]
        public void Test_CountQueens()
        {
            Assert.AreEqual(0, sixteenQueenPuzzle.CountQueens()); // No queens
            sixteenQueenPuzzle.ToggleQueen(0, 0);
            Assert.AreEqual(1, sixteenQueenPuzzle.CountQueens()); // One queen 
            sixteenQueenPuzzle.ToggleQueen(1, 1);
            Assert.AreEqual(2, sixteenQueenPuzzle.CountQueens()); // Two queens 
        }

        [TestMethod]
        public void Test_IsValidSolution()
        {
            // Test an invalid solution
            sixteenQueenPuzzle.ToggleQueen(0, 0);
            sixteenQueenPuzzle.ToggleQueen(0, 1);
            Assert.IsFalse(sixteenQueenPuzzle.IsValidSolution()); // Queens in the same row

        }

        [TestMethod]
        public void Test_FindSolutionsSequentially()
        {
            var solutions = sixteenQueenPuzzle.FindSolutionsSequentially(10);
            Assert.IsTrue(solutions.Count > 0); 
        }

        [TestMethod]
        public async Task Test_FindSolutionsThreadedAsync()
        {
            var solutions = await sixteenQueenPuzzle.FindSolutionsThreadedAsync(10);
            Assert.IsTrue(solutions.Count > 0); 
        }

        [TestMethod]
        public async Task Test_SaveSequentialSolutionsToDatabaseAsync()
        {
            var solutions = new List<List<int>> { new List<int> { 0, 2, 4, 6, 8, 10, 12, 14, 1, 3, 5, 7, 9, 11, 13, 15 } };
            await DatabaseManager.SaveSequentialSolutionsToDatabaseAsync(solutions);

            
        }

        [TestMethod]
        public async Task Test_SaveThreadedSolutionsToDatabaseAsync()
        {
            var solutions = new List<List<int>> { new List<int> { 15, 13, 11, 9, 7, 5, 3, 1, 14, 12, 10, 8, 6, 4, 2, 0 } };
            await DatabaseManager.SaveThreadedSolutionsToDatabaseAsync(solutions);

            
        }

        [TestCleanup]
        public void Cleanup()
        {
            sixteenQueenPuzzle = null;
            dbManager = null;
        }
    }
}
