Imports AForge
Imports AForge.Video
Imports AForge.Video.DirectShow
Public Class Camera
    Private CAMERA As VideoCaptureDevice
    Private bmp As Bitmap
    Private Sub Camera_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CamStart()
    End Sub

    Private Sub CamStart()
        Dim cameras As VideoCaptureDeviceForm = New VideoCaptureDeviceForm
        If cameras.ShowDialog() = Windows.Forms.DialogResult.OK Then
            If cameras Is Nothing Then
                Return
            End If
            CAMERA = cameras.VideoDevice
            AddHandler CAMERA.NewFrame, New NewFrameEventHandler(AddressOf Captured)
            CAMERA.Start()
        Else
            Me.Hide()
        End If
    End Sub

    Private Sub Captured(sender As Object, eventArgs As NewFrameEventArgs)
        bmp = DirectCast(eventArgs.Frame.Clone(), Bitmap)
        bmp.RotateFlip(RotateFlipType.RotateNoneFlipX)
        PictureBox1.Image = bmp
    End Sub

    Private Sub Camera_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        CAMERA.Stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        EditCitizens.PboxImg.Image = PictureBox1.Image
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        CAMERA.Stop()
        CamStart()
    End Sub
End Class