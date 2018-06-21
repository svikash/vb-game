Public Class end_text
    Dim speed As Integer
    Dim road(7) As PictureBox
    Dim score As Integer = 0


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load, Car.Click
       
       
        speed = 4
        road(0) = PictureBox1
        road(1) = PictureBox2
        road(2) = PictureBox3
        road(3) = PictureBox4
        road(4) = PictureBox5
        road(5) = PictureBox6
        road(6) = PictureBox7
        road(7) = PictureBox8
    End Sub


    Private Sub road_mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles road_mover.Tick
        For x As Integer = 0 To 7
            road(x).Top += speed

            If road(x).Top >= Me.Height Then
                road(x).Top = -road(x).Height

            End If
        Next
        If score > 10 And score < 20 Then
            speed = 5

        End If
        If score > 20 And score < 30 Then
            speed = 7
        End If
        If score > 30 And score < 50 Then
            speed = 10
        End If

        If score > 30 And score < 50 Then

            Label3.Text = "speed" & speed


        End If
        If score > 50 And score < 100 Then

            speed = 8

        End If

        If (Car.Bounds.IntersectsWith(PictureBox9.Bounds)) Then
            GameOver()


        End If

        If (Car.Bounds.IntersectsWith(PictureBox10.Bounds)) Then
            GameOver()


        End If

        If (Car.Bounds.IntersectsWith(PictureBox11.Bounds)) Then
            GameOver()


        End If

    End Sub
    Private Sub GameOver()




        Button1.Visible = True
        Label1.Visible = True
        road_mover.Stop()
        Timer1.Stop()
        Timer2.Stop()
        Timer3.Stop()










    End Sub



    Private Sub PictureBox7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Right Then
            right_mover.Start()



        End If
        If e.KeyCode = Keys.Left Then
            Car.Left -= 5
            left_mover.Start()



        End If
    End Sub

    Private Sub PictureBox10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox10.Click

    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        PictureBox9.Top += speed


        If PictureBox9.Top >= Me.Height Then
            score += 1
            Label2.Text = "Score" & score


            PictureBox9.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + PictureBox9.Height)
            PictureBox9.Left = -CInt(Math.Ceiling(Rnd() * 60)) + 30






        End If


    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        PictureBox10.Top += speed

        If PictureBox10.Top >= Me.Height Then
            score += 1
            Label2.Text = "Score" & score
            PictureBox10.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + PictureBox10.Height)
            PictureBox10.Left = -CInt(Math.Ceiling(Rnd() * 90)) + 160








        End If




    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        PictureBox11.Top += speed * 3 / 2
        If PictureBox11.Top >= Me.Height Then
            score += 1
            Label2.Text = "Score" & score
            PictureBox11.Top = -(CInt(Math.Ceiling(Rnd() * 150)) + PictureBox11.Height)
            PictureBox11.Left = -CInt(Math.Ceiling(Rnd() * 170)) + 170
        End If



    End Sub

    Private Sub left_mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles left_mover.Tick
        If (Car.Location.X > 0) Then
            Car.Left -= 5



        End If

    End Sub

    Private Sub right_mover_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right_mover.Tick
        If (Car.Location.X < 180) Then
            Car.Left += 5
        End If

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        right_mover.Stop()
        left_mover.Stop()




    End Sub

    Private Sub PictureBox9_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox9.Click

    End Sub

    Private Sub PictureBox11_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox11.Click

    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        score = 0
        Me.Controls.Clear()
        InitializeComponent()
        Form1_Load(e, e)






    End Sub

   
   
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        road_mover.Start()






    End Sub
End Class
