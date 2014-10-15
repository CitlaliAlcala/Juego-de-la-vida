Public Class Juego

    'Asignación de PictureBoxes al arreglo bidimensional
    Dim n = New PictureBox()
    Dim flag(64) As Integer
    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Asignación de PictureBoxes al arreglo bidimensional
        n = {PB11, PB12, PB13, PB14, PB15, PB16, PB17, PB18, PB21, PB22, PB23, PB24, PB25, PB26, PB27, PB28, PB31, PB32, PB33, PB34, PB35, PB36, PB37, PB38, PB41, PB42, PB43, PB44, PB45, PB46, PB47, PB48, PB51, PB52, PB53, PB54, PB55, PB56, PB57, PB58, PB61, PB62, PB63, PB64, PB65, PB66, PB67, PB68, PB71, PB72, PB73, PB74, PB75, PB76, PB77, PB78, PB81, PB82, PB83, PB84, PB85, PB86, PB87, PB88}

        'Inicia el juego con los siguientes valores
        'Los valores pueden cambiarse para ver distintos patrones
        PB14.BackColor = Color.Black
        PB24.BackColor = Color.Black
        PB34.BackColor = Color.Black
        PB51.BackColor = Color.Black
        PB52.BackColor = Color.Black
        PB53.BackColor = Color.Black
        PB55.BackColor = Color.Black
        PB56.BackColor = Color.Black
        PB57.BackColor = Color.Black
        PB71.BackColor = Color.Black
        PB72.BackColor = Color.Black
        PB81.BackColor = Color.Black
        PB82.BackColor = Color.Black
        PB27.BackColor = Color.Black
        PB37.BackColor = Color.Black
        PB17.BackColor = Color.Black
        PB48.BackColor = Color.Black
        PB58.BackColor = Color.Black
        PB12.BackColor = Color.Black
        PB23.BackColor = Color.Black
        PB34.BackColor = Color.Black



      



    End Sub


    Private Sub CmdSiguiente_Click(sender As Object, e As EventArgs) Handles CmdSiguiente.Click
        Dim cont As Integer
        For x = 0 To 63
            cont = 0
            'Evaluación de las esquinas
            If x = 0 Then
                If n(1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
            ElseIf x = 7 Then
                If n(6).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(14).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(15).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
            ElseIf x = 56 Then
                If n(48).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(49).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(57).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
            ElseIf x = 63 Then
                If n(62).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(54).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(55).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
            End If

            'Evaluación orilla izquierda
            If x = 8 Or x = 16 Or x = 24 Or x = 32 Or x = 40 Or x = 48 Then
                If n(x - 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 7).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                'Evaluación de la orilla derecha
            ElseIf x = 15 Or x = 23 Or x = 31 Or x = 39 Or x = 47 Or x = 55 Then
                If n(x - 9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 7).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                'Evaliación de la orilla superior
            ElseIf x >= 1 And x <= 6 Then
                If n(x - 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 7).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                'Evaluación de la orilla inferior
            ElseIf x >= 57 And x <= 62 Then
                If n(x - 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 7).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                'Evaluacion de las casillas centrales
            ElseIf x <> 0 And x <> 7 And x <> 56 And x <> 63 Then 'Este if sumula la opción por default 
                If n(x - 9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 7).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x - 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 1).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 7).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 8).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
                If n(x + 9).BackColor.ToKnownColor = KnownColor.Black Then
                    cont = cont + 1
                End If
            End If

            'Evaluacion de las celulas (Reglas del juego de la vida)
            If cont < 2 Then
                flag(x) = 0
            ElseIf cont > 3 Then
                flag(x) = 0
            ElseIf cont = 3 Then
                flag(x) = 1
            End If

        Next

        'For que genera el cambio a la siguiente generación 
        For a = 0 To 63
            If flag(a) = 0 Then
                n(a).Backcolor = Color.White
            End If
            If flag(a) = 1 Then
                n(a).Backcolor = Color.Black
            End If
        Next
    End Sub
   
End Class