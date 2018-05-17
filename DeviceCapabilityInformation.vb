Imports Atalasoft.Twain
Imports System
Imports System.Windows.Forms

Public Class DeviceCapabilityInformation

    Private _device As Device

    Public Sub New(ByVal twainDevice As Device)
        _device = twainDevice
        InitializeComponent()
        LoadCapabilities()
    End Sub

    Private Sub listCapabilities_SelectedIndexChanged(ByVal sender As Object, ByVal e As EventArgs) Handles listCapabilities.SelectedIndexChanged
        If Me.listCapabilities.SelectedIndex = -1 Then
            Return
        End If
        Dim cap As DeviceCapability = CType(Me.listCapabilities.SelectedItem, DeviceCapability)

        Me.listValues.Items.Clear()

        Me.lblCapType.Text = _device.Controller.GetCapabilityTwainType(cap).ToString()

        Dim operations As QueryOperation = _device.GetQueryOperations(cap)
        FillOperationList(operations)

        If (operations And QueryOperation.TWQC_GET) = QueryOperation.TWQC_GET Then
            Dim capability As New TwainCapability(cap, TwainContainer.TWON_DONTCARE16, IntPtr.Zero)
            If _device.Controller.SendCommand(TwainTriplet.CapabilityGet, _device.Identity, capability) = TwainReturnCode.TWRC_SUCCESS Then
                Me.lblGetContainer.Text = capability.ContainerType.ToString()

                ' Always use a TwainMemory object when working with memory returned from a driver.
                Dim memory As TwainMemory = _device.Controller.CreateTwainMemory(capability.Data)
                Try
                    Dim vals As Object = _device.Controller.ReadTwainContainerData(capability.ContainerType, memory)

                    FillValueList(vals, cap)
                Catch ex As Exception
                    MessageBox.Show("ReadTwainContainerData failed for " & cap.ToString() & Microsoft.VisualBasic.Constants.vbCrLf & Microsoft.VisualBasic.Constants.vbCrLf & ex.Message & Microsoft.VisualBasic.Constants.vbCrLf & ex.StackTrace)
                Finally
                    memory.Dispose()
                End Try
            Else
                Me.lblGetContainer.Text = "Unknown"
            End If
        Else
            Me.lblGetContainer.Text = "Not Supported"
        End If

        If (operations And QueryOperation.TWQC_GETCURRENT) = QueryOperation.TWQC_GETCURRENT Then
            Dim capability As New TwainCapability(cap, TwainContainer.TWON_DONTCARE16, IntPtr.Zero)
            If _device.Controller.SendCommand(TwainTriplet.CapabilityGet, _device.Identity, capability) = TwainReturnCode.TWRC_SUCCESS Then
                Me.lblGetCurrentContainer.Text = capability.ContainerType.ToString()

                ' Don't forget to free the memory allocated by the driver.
                _device.Controller.FreeTwainMemory(capability.Data)
            Else
                Me.lblGetContainer.Text = "Unknown"
            End If
        Else
            Me.lblGetCurrentContainer.Text = "Not Supported"
        End If
    End Sub

    Private Sub LoadCapabilities()
        Dim caps() As DeviceCapability = _device.GetSupportedCapabilities()
        For Each cap As DeviceCapability In caps
            Me.listCapabilities.Items.Add(cap)
        Next cap
    End Sub

    Private Sub FillOperationList(ByVal operations As QueryOperation)
        Me.listOperations.SetItemCheckState(0, If(((operations And QueryOperation.TWQC_NONE) = QueryOperation.TWQC_NONE), CheckState.Checked, CheckState.Unchecked))
        Me.listOperations.SetItemCheckState(1, If(((operations And QueryOperation.TWQC_GET) = QueryOperation.TWQC_GET), CheckState.Checked, CheckState.Unchecked))
        Me.listOperations.SetItemCheckState(2, If(((operations And QueryOperation.TWQC_SET) = QueryOperation.TWQC_SET), CheckState.Checked, CheckState.Unchecked))
        Me.listOperations.SetItemCheckState(3, If(((operations And QueryOperation.TWQC_GETDEFAULT) = QueryOperation.TWQC_GETDEFAULT), CheckState.Checked, CheckState.Unchecked))
        Me.listOperations.SetItemCheckState(4, If(((operations And QueryOperation.TWQC_GETCURRENT) = QueryOperation.TWQC_GETCURRENT), CheckState.Checked, CheckState.Unchecked))
        Me.listOperations.SetItemCheckState(5, If(((operations And QueryOperation.TWQC_RESET) = QueryOperation.TWQC_RESET), CheckState.Checked, CheckState.Unchecked))
    End Sub

    Private Sub FillValueList(ByVal values As Object, ByVal capability As DeviceCapability)
        If values Is Nothing Then
            Return
        End If

        Dim vals() As Object = TryCast(values, Object())
        If vals Is Nothing Then
            Me.listValues.Items.Add(values)
        ElseIf vals.Length > 0 Then
            Me.listValues.Items.AddRange(vals)
        End If
    End Sub
End Class