Imports Newtonsoft.Json.Linq
Imports System.IO
Imports System.Net
Imports System.Text

Public Class Form5

    Dim dataSetId As String = "" 'UID of Dataset
    Dim todayDate As String = Date.Now().ToString("yyyy-MM-dd") 'Today Date
    Dim period As String = "" 'Eg: 208101 for 2080 Baisakh
    Dim orgUnitId As String = "" 'Eg: Hospital UID
    Dim attributeOptionCombo As String = "" 'Only for ICD11 disease, UID of ICD11 disease
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TxtOrgUnitId.Text = "BAGHAUDA HOSPTIAL_CHITAWAN"
        ComPeriodId.Enabled = False
        Button1.Enabled = False
        Button2.Enabled = False
        Panel1.Hide()
        Panel2.Hide()
        Panel5.Hide()
        Label9.Hide()
        Button3.Enabled = False
    End Sub

    Private Sub ComDataSetId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComDataSetId.SelectedIndexChanged
        ComPeriodId.Enabled = True
        Button1.Enabled = True
        Button2.Enabled = True
        Button3.Enabled = False
    End Sub

    Private Sub ComPeriodId_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComPeriodId.SelectedIndexChanged
        Panel1.Show()
        Panel2.Show()
        Panel5.Show()
        Label9.Show()
        Button3.Enabled = True
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If ComDataSetId.SelectedItem = "01-2 Hospital Summary Dataset(NEW)" Then
            dataSetId = "CjuEkVeLgsT"
        End If
        If TxtOrgUnitId.Text = "BAGHAUDA HOSPTIAL_CHITAWAN" Then
            orgUnitId = "aUv4lHwAFh9"
        End If
        If ComPeriodId.SelectedItem = "Baishak 2081" Then
            period = "208101"
        ElseIf ComPeriodId.SelectedItem = "Jestha 2081" Then
            period = "208102"
        End If

        Dim apiUrl As String = "https://hmis.gov.np/hmisdemo/api/dataValueSets"
        Dim userName As String = "baghauda.hosp"
        Dim passWord As String = "Hmis@3344"
        Dim jsonData As String = "{" &
    """dataSet"": """ & dataSetId & """," &
 "   ""completeDate"": """ & todayDate & """," &
 "   ""period"": """ & period & """," &
 "   ""orgUnit"": """ & orgUnitId & """," &
 "   ""attributeOptionCombo"": """"," &
 "   ""dataValues"": [" &
 "       {" &
 "           ""dataElement"": ""W7SEWzmObUP""," &
 "           ""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
 "           ""value"": """ & TextBox6.Text & """," &
 "           ""comment"": ""Female---Referral In""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""O7vdFXujKQX""," &
 "           ""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
 "           ""value"": """ & TextBox5.Text & """," &
 "           ""comment"": ""Female---Outpatient""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""cUMLBeIlaIp""," &
 "           ""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
 "           ""value"": """ & TextBox4.Text & """," &
 "           ""comment"": ""Female---In-patient""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""R8gvkj9ssaI""," &
 "           ""categoryOptionCombo"": ""ye1QuAMRG5Z""," &
 "           ""value"": """ & TextBox3.Text & """," &
 "           ""comment"": ""Female---Emergency""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""W7SEWzmObUP""," &
 "           ""categoryOptionCombo"": ""PflKpozpO7b""," &
 "           ""value"": """ & TextBox7.Text & """," &
 "           ""comment"": ""Male---Referral In""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""O7vdFXujKQX""," &
 "           ""categoryOptionCombo"": ""PflKpozpO7b""," &
 "           ""value"": """ & TextBox8.Text & """," &
 "           ""comment"": ""Male---Outpatient""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""cUMLBeIlaIp""," &
 "           ""categoryOptionCombo"": ""PflKpozpO7b""," &
 "           ""value"": """ & TextBox2.Text & """," &
 "           ""comment"": ""Male---In-patient""" &
 "       }," &
 "       {" &
 "           ""dataElement"": ""R8gvkj9ssaI""," &
 "           ""categoryOptionCombo"": ""PflKpozpO7b""," &
 "           ""value"": """ & TextBox1.Text & """," &
 "           ""comment"": ""Male---Emergency""" &
 "       }" &
 "   ]" &
"}"
        Dim response As String = SubmitData(apiUrl, userName, passWord, jsonData)
    End Sub


    Public Shared Function SubmitData(ByVal apiUrl As String, ByVal username As String, ByVal password As String, ByVal jsonData As String) As String
        Dim ReturnValue As String = ""
        Dim request As HttpWebRequest = CType(WebRequest.Create(apiUrl), HttpWebRequest)
        request.Method = "POST"
        request.ContentType = "application/json"
        Dim credentials As String = Convert.ToBase64String(Encoding.ASCII.GetBytes(username & ":" + password))
        request.Headers(HttpRequestHeader.Authorization) = "Basic " & credentials

        Try

            Using writer As StreamWriter = New StreamWriter(request.GetRequestStream())
                writer.Write(jsonData)
                writer.Flush()
            End Using

            Using response As HttpWebResponse = CType(request.GetResponse(), HttpWebResponse)

                Using responseStream As Stream = response.GetResponseStream()

                    Using reader As StreamReader = New StreamReader(responseStream)
                        Dim responseJson As String = reader.ReadToEnd()
                        Dim responseObject As Object = JObject.Parse(responseJson)
                        Dim status As String = responseObject("status").ToString()
                        MsgBox(status)

                    End Using
                End Using
            End Using

        Catch ex As WebException
            ReturnValue = ex.Message
            MsgBox(ReturnValue)

        End Try

        Return ReturnValue

    End Function


End Class