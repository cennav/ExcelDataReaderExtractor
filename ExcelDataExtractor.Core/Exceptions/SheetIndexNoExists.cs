﻿using ExcelDataExtractor.Core.Constants;

namespace ExcelDataExtractor.Core.Exceptions;
/// <summary>
/// Exception thrown when the sheet index provided does not exists in the file.
/// </summary>
public class SheetIndexNoExists : SheetException
{
    public SheetIndexNoExists() : base(ExceptionMessages.SheetIndexNoExists)
    {
    }
}




