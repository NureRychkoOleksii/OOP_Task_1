using System;
using System.Linq;
using OOPTask1;
using Xunit;
using FluentAssertions;

namespace OOP_Task_1_Unit_Tests
{
    public class UnitTest1
    {
        private readonly File_Info fi = new File_Info(@"C:\Users\moonler\Desktop\мусор");

        [Fact]

        public void FileOutputCheck()
        {
            //Arrange
            string result = @"C:\Users\moonler\Desktop\мусор\1551794476188568787.jpg";

            //Act
            var output = fi.FileOutput();

            //Assert

            output.ToList().Contains(result);
        }

        [Fact]

        public void FileOutputByNameCheck()
        {
            // Arrange

            string result = "1551794476188568787.jpg";

            // Act

            var output = fi.FileOutputByName();

            // Assert

            output.ToList().First().Equals(result);
        }

        [Fact]

        public void FileOutputBySizeCheck()
        {
            // Arrange

            string result = "Лаб-2.docx";

            // Act

            var output = fi.FileOutputBySize();

            // Assert

            output.ToList().First().Equals(result);
        }

        [Fact]

        public void FileOutput200SymbolsCheck()
        {
            // Arrange

            string result = "asdasdasdasdasdasd";

            // Act

            var output = fi.FileOutput200Symbols("asd.txt");

            // Assert

            output.ToList().First().Equals(result);
        }

        [Fact]

        public void FileOuputHiddenFilesTooCheck()
        {
            // Arrange

            string result = "5c3c9a4b5bf5f.jpeg";

            // Act

            var output = fi.FileOutputHiddenFilesToo();

            // Assert

            output.Contains("5c3c9a4b5bf5f.jpeg");
        }

        [Fact]

        public void FindSubStrCheck()
        {
            // Arrange

            bool result = true;

            // Act

            var output = fi.FindSubStr("asd","asd.txt");

            // Assert

            Assert
                .True(result);
        }
    }
}