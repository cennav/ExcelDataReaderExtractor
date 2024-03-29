﻿namespace ExcelDataExtractor.Core.Exceptions;

/// <summary>
/// Abstract class inherited by exceptions related exclusively to fields.
/// </summary>
public abstract class FieldException : Exception
{
    public FieldException(string message) : base(message)
    {
    }
}
