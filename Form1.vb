Public Class Form1
    'To be accessible to all
    Dim intXOrigin, intYOrigin As Integer
    Dim sngA As Single = 1
    Dim sngZoom As Single = 0.5
    Dim blnPlot As Boolean = False
    Private Sub DrawAxes(ByVal g As Graphics)
        'to put in the center
        intXOrigin = picOut.Width \ 2
        intYOrigin = picOut.Height \ 2
        'initializing font
        Dim myfont As New Font("Arial", 8, FontStyle.Regular)
        g.Clear(Color.Black)
        g.DrawLine(Pens.Gray, 0, intYOrigin, picOut.Width, intYOrigin)
        g.DrawLine(Pens.Gray, intXOrigin, 0, intXOrigin, picOut.Height)
        g.DrawString("(0, 0)", myfont, Brushes.Gray, intXOrigin - 15, intYOrigin + 5)
        'to determine if the axes have labels or not
        Select Case blnPlot
            Case True
                'for the labels to adjust
                Dim radiansPerPixel As Single = 720 / picOut.Width * sngZoom
                Dim tickstepX As Single = 15
                Dim labelstepX As Single = 45
                Dim scaleY As Single = (picOut.Height / 2) / (sngA * 2)
                Dim yStep As Single = sngA
                Dim xPixel, ypixel As Integer
                Dim theta, yval As Single
                'x axis
                For theta = 15 To 720 Step tickstepX
                    xPixel = intXOrigin + CInt(theta / radiansPerPixel)
                    g.DrawLine(Pens.Gray, xPixel, intYOrigin - 3, xPixel, intYOrigin + 3)

                    If theta Mod labelstepX = 0 Then
                        g.DrawString(Math.Round(theta, 0).ToString(), myfont, Brushes.Gray, xPixel - 10, intYOrigin + 5)
                    End If
                Next

                For theta = 15 To 720 Step tickstepX
                    xPixel = intXOrigin - CInt(theta / radiansPerPixel)
                    g.DrawLine(Pens.Gray, xPixel, intYOrigin - 3, xPixel, intYOrigin + 3)

                    If theta Mod labelstepX = 0 Then
                        g.DrawString("-" & Math.Round(theta, 0).ToString(), myfont, Brushes.Gray, xPixel - 15, intYOrigin + 5)
                    End If
                Next
                'yaxis
                For yval = yStep To sngA * 2 Step yStep
                    ypixel = intYOrigin - CInt(yval * scaleY)
                    g.DrawLine(Pens.Gray, intXOrigin - 3, ypixel, intXOrigin + 3, ypixel)
                    g.DrawString(yval.ToString(), myfont, Brushes.Gray, intXOrigin + 5, ypixel - 8)
                Next

                For yval = yStep To sngA * 2 Step yStep
                    ypixel = intYOrigin + CInt(yval * scaleY)
                    g.DrawLine(Pens.Gray, intXOrigin - 3, ypixel, intXOrigin + 3, ypixel)
                    g.DrawString("-" & yval.ToString(), myfont, Brushes.Gray, intXOrigin + 5, ypixel - 8)
                Next
                'change to the equation with the correct amplitude
                g.DrawString("graph of the function", myfont, Brushes.Green, 0, 0)
                g.DrawString("y = " & sngA & " sinx", myfont, Brushes.Coral, 0, 15)
                g.DrawString("y = " & sngA & " cosx", myfont, Brushes.DodgerBlue, 0, 25)
            Case False
                'when no amplitude
                g.DrawString("This program plots the general function" & vbNewLine & "y = A sinx and y = A cosx" & vbNewLine & "Please input the appropriate value of A" _
                         & vbNewLine & "to the respective textbox", myfont, Brushes.Green, 0, 0)
        End Select
    End Sub
    Private Sub picOut_Paint(sender As Object, e As PaintEventArgs) Handles picOut.Paint
        Dim gpaint As Graphics = e.Graphics
        'to have a proper output
        'drawing the sin and cos line
        Select Case blnPlot
            Case True
                Call DrawAxes(gpaint)

                Dim penSin As New Pen(Color.Coral, 2)
                Dim penCos As New Pen(Color.DodgerBlue, 2)
                Dim xPixel As Integer
                Dim xValue, ySin, yCos, prevX, prevYsin, prevYcos As Single
                Dim scaleX As Single = sngZoom
                Dim scaleY As Single = (picOut.Height / 2) / (sngA * 2)

                For xPixel = 0 To picOut.Width
                    xValue = (xPixel - intXOrigin) / (picOut.Width / (4 * Math.PI)) * scaleX
                    ySin = intYOrigin - sngA * Math.Sin(xValue) * scaleY
                    yCos = intYOrigin - sngA * Math.Cos(xValue) * scaleY

                    If xPixel > 0 Then
                        gpaint.DrawLine(penSin, prevX, prevYsin, xPixel, ySin)
                        gpaint.DrawLine(penCos, prevX, prevYcos, xPixel, yCos)
                    End If

                    prevX = xPixel
                    prevYsin = ySin
                    prevYcos = yCos
                Next
            Case Else
                gpaint.Clear(Color.Black)
                Call DrawAxes(gpaint)
        End Select
    End Sub
    Private Sub FormReset(sender As Object, e As EventArgs) Handles Me.Load, btnReset.Click
        'reset when load or click
        picOut.BackColor = Color.Black
        blnPlot = False
        sngZoom = 1
        sngA = 1
        txtAmp.Clear()
        txtAmp.Focus()
        txtAmp.ReadOnly = False
        btnZIn.Enabled = False
        btnZOut.Enabled = False
        Me.Width = 550
        Me.Height = 400
        Me.CenterToScreen()
        picOut.Refresh()
    End Sub
    Private Sub btnPlot_Click(sender As Object, e As EventArgs) Handles btnPlot.Click
        Try
            'to convert to single
            sngA = CSng(txtAmp.Text)
            'to filter out numbers less than or equal to 0
            If sngA <= 0 Then
                MessageBox.Show("The amplitude should be greater than 0.")
                FormReset(Nothing, Nothing)
                Exit Sub
            End If

            blnPlot = True
            txtAmp.ReadOnly = True
            btnZIn.Enabled = True
            btnZOut.Enabled = True
            picOut.Refresh()
        Catch ex As Exception
            'when other characters are inserted or other error are encountered
            MessageBox.Show("Oops!!!", "Error")
            FormReset(Nothing, Nothing)
        End Try
    End Sub
    Private Sub btnZIn_Click(sender As Object, e As EventArgs) Handles btnZIn.Click
        'zoom in by a factor of 2
        sngZoom = sngZoom / 2
        picOut.Refresh()
    End Sub
    Private Sub btnZOut_Click(sender As Object, e As EventArgs) Handles btnZOut.Click
        'zoom out by a factor of 2
        sngZoom = sngZoom * 2
        picOut.Refresh()
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        'redraw itself
        picOut.Refresh()
    End Sub
End Class