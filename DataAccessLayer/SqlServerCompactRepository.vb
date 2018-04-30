Imports BusinessLayer

Public Class SqlServerCompactRepository
    Implements IRepository

    Private Function IRepository_SaveSpeaker(speaker As Speaker) As Integer Implements IRepository.SaveSpeaker
        Return 1
    End Function

    Public Function GetRegistrationFee(yearsExperience As Integer?) As Integer Implements IRepository.GetRegistrationFee

        Dim feeFakeData As List(Of FeeTable) = New List(Of FeeTable) From {New FeeTable With {.Fee = 500, .MinYearExperience = 0, .MaxYearExperience = 1}, New FeeTable With {.Fee = 250, .MinYearExperience = 2, .MaxYearExperience = 3}, New FeeTable With {.Fee = 100, .MinYearExperience = 4, .MaxYearExperience = 5}, New FeeTable With {.Fee = 50, .MinYearExperience = 6, .MaxYearExperience = 9}}
        Dim feedResult = feeFakeData.FirstOrDefault(Function(x) x.MinYearExperience >= yearsExperience AndAlso x.MaxYearExperience <= yearsExperience)
        Return If(feedResult?.Fee, 0)

    End Function
End Class