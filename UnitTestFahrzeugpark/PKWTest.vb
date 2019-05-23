Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting
Imports Fahrzeugpark

'UNIT-TESTS sind simple Überprüfungen, mit denen kleine Programmteile über längere Zeit auf ihre korrekte
''Funktionalität hin überprüft werden können. Ausgeführt werden diese über das 'Test'-Menü
<TestClass()> Public Class PKWTest

    <TestMethod()> Public Sub Beschleunige_über_MaxG()

        Dim pkw1 As PKW = New PKW("BMW", 290, 29000, 5)

        pkw1.StarteMotor()
        pkw1.Beschleunige(300)

        'Jede TestMethod muss mindestens einen Zugriff auf die Assert-Klasse nehmen, mit deren Methoden die
        ''zu überprüfenden Programmteile getestet werden. Ein Test gilt als erfolgreich, wenn alle Assert-Methoden
        ''in einer TestMethod ein true zurückgeben.
        Assert.AreEqual(pkw1.MaxGeschwindigkeit, pkw1.AktGeschwindigkeit)

    End Sub

End Class