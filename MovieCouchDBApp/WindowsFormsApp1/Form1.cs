using MyCouch.Contexts;
using MyCouch.Querying;
using MyCouch.Requests;
using MyCouch.Responses;
using MyCouch.Serialization;
using Newtonsoft.Json;
using MyCouch;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
using System.Collections;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        string link = "http://localhost:5984/";
        string databaseName = "movies";



      
        public Form1()
        {
            InitializeComponent();

         
        }
      

        private async void GetEveryDoc()
        {
            dataViewAll.Rows.Clear();

            using (var dbClient = new MyCouchClient(link, databaseName))
            {
                var dbQuery = new QueryViewRequest("_all_docs");
                var responseDB = await dbClient.Views.QueryAsync<dynamic>(dbQuery);
                dynamic array = responseDB.Rows.ToArray();

                foreach(var keyValue in array)
                {
                    dataViewAll.Rows.Add(keyValue.Key.ToString());
                    MessageBox.Show(keyValue.Key.ToString() + ":" + keyValue.Value.ToString(),"Film Documents IDs",MessageBoxButtons.OK);
                }

                dataViewAll.AutoResizeColumns();
                dataViewAll.AutoResizeRows();
            }

        }

        /*private async void GetMapReduce()
        {
            grdDataViewChoice.Rows.Clear();

            using (var dbClient = new MyCouchClient(link, databaseName))
            {
                var dbQuery = new QueryViewRequest("_design/Movies");
                var responseDB = await dbClient.Views.QueryAsync<dynamic>(dbQuery);
                dynamic array = responseDB.Rows.ToArray();

                foreach (var keyValue in array)
                {
                    grdDataViewChoice.Rows.Add(keyValue.Key.ToString());
                    MessageBox.Show(keyValue.Key.ToString() + ":" + keyValue.Value.ToString(), "Film Documents IDs", MessageBoxButtons.OK);
                }

                grdDataViewChoice.AutoResizeColumns();
                grdDataViewChoice.AutoResizeRows();
            }

        }*/


        private void GetAndReadChosenDoc(string documentID)
        {
            dataSelectedMovie.Rows.Clear();

            using (var dbClient = new MyCouchClient(link, databaseName))
            {
                var getDocResponse = dbClient.Documents.GetAsync(documentID);

                dynamic a = JsonConvert.DeserializeObject<Dictionary<string, string>>(getDocResponse.Result.Content);

                txtID.Text = a["_id"];
                txtRev.Text = a["_rev"];
                txtTitle.Text = a["title"];
                txtYr.Text = a["year"];
                txtDirector.Text = a["director"];
                txtProducer.Text = a["producer"];
                txtComposer.Text = a["composer"];
                txtRuntime.Text = a["runtimeinminutes"];
                txtCompany.Text = a["company"];
                txtPrice.Text = a["price"];
                txtNoInStock.Text = a["numberinstock"];

                foreach (var keyValue in a)
                {
                    dataSelectedMovie.Rows.Add(keyValue.Key.ToString() + ":", keyValue.Value.ToString());
                    Console.WriteLine(keyValue.Key.ToString() + ":" + keyValue.Value.ToString());
                }

                dataSelectedMovie.AutoResizeColumns();
                dataSelectedMovie.AutoResizeRows();
            }
        }


        private async void formNewMovie()
        {
          using (var dbClient = new MyCouchClient(link, databaseName))
            {
                /*var dbObject = new DataObject

                  (_id = txtID.Text,
                   title = txtTitle.Text,
                   year = int.Parse(txtYr.Text),
                   director = txtDirector.Text,
                   producer = txtProducer.Text,
                   composer = txtComposer.Text,
                   runtimeInMinutes = int.Parse(txtRuntime.Text),
                   company = txtCompany.Text,
                   price = int.Parse(txtPrice.Text),
                   numberInStock = int.Parse(txtNoInStock.Text));*/

               /* var dbObject = new DataObject
                   (txtID.Text,
                   txtTitle.Text,
                    int.Parse(txtYr.Text),
                   txtDirector.Text,
                  txtProducer.Text,
                   txtComposer.Text,
                   int.Parse(txtRuntime.Text),
                   txtCompany.Text,
                   int.Parse(txtPrice.Text),
                    int.Parse(txtNoInStock.Text));*/

                /*Movie movieObject = new Movie(txtID.Text,
                    txtTitle.Text,
                   int.Parse(txtYr.Text),
                    txtDirector.Text,
                     txtProducer.Text,
                    txtComposer.Text,
                    int.Parse(txtRuntime.Text),
                     txtCompany.Text,
                     int.Parse(txtPrice.Text),
                     int.Parse(txtNoInStock.Text));*/


               var filmObject = new DataObject("{\"_id\":\"" + txtID.Text + "\"," +
                    "title\":\"" + txtTitle.Text + "\"," +
                     "year\":\"" + txtYr.Text + "\"," +
                      "director\":\"" + txtDirector.Text + "\"," +
                       "producer\":\"" + txtProducer.Text + "\"," +
                          "composer\":\"" + txtComposer.Text + "\"," +
                             "runtimeinminutes\":\"" + txtRuntime.Text + "\"," +
                                "company\":\"" + txtCompany.Text + "\"," +
                                 "price\":\"" + txtPrice.Text + "\"," +
                                 "numberinstock\":\"" + txtNoInStock.Text + "\"}");




               //var dbObject = new DataObject("movie",movieObject);

               // var dbObject = new DataObject("movie", filmObject);


                 //var response = await dbClient.Entities.PostAsync(dbObject);

                 var response = await dbClient.Entities.PostAsync(filmObject);        


            }

            GetEveryDoc();
        }
            
        


        private async void updateMovieDocument(string movieDocument)
        {
            using (var dbClient = new MyCouchClient(link, databaseName))
            {
                var dbObject = "{\"_id\":\"" + movieDocument + "\"," +
                    "_rev\":\"" + txtRev.Text + "\"," +
                     "title\":\"" + txtTitle.Text + "\"," +
                      "year\":\"" + txtYr.Text + "\"," +
                       "director\":\"" + txtDirector.Text + "\"," +
                        "producer\":\"" + txtProducer.Text + "\"," +
                           "composer\":\"" + txtComposer.Text + "\"," +
                              "runtimeinminutes\":\"" + txtRuntime.Text + "\"," +
                                 "company\":\"" + txtCompany.Text + "\"," +
                                  "price\":\"" + txtPrice.Text + "\"," +
                                  "numberinstock\":\"" + txtNoInStock.Text + "\",";
                                                                    

                await dbClient.Documents.PutAsync(movieDocument, txtRev.Text, "{\"title\":\"" + txtTitle.Text + "\",\"year\":\"" + txtYr.Text + "\",\"director\":\"" + txtDirector.Text + "\",\"producer\":\"" + txtProducer.Text + "\",\"composer\":\"" + txtComposer.Text + "\",\"runtimeinminutes\":\"" + txtRuntime.Text + "\",\"company\":\"" + txtCompany.Text + "\",\"price\":\"" + txtPrice.Text + "\",\"numberinstock\":\"" + txtNoInStock.Text + "\"}");
              
            }
            GetAndReadChosenDoc(movieDocument);
        }



        private async void deleteMovie(string filmID, string revNo)
        {
            using (var dbClient = new MyCouchClient(link, databaseName))
            {
                await dbClient.Documents.DeleteAsync(filmID,revNo);
            }

            GetEveryDoc();
        }


        private void reloadDatabase_Click(object sender, EventArgs e)
        {
            //GetMapReduce();
            GetEveryDoc();
           
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            deleteMovie(txtID.Text, txtRev.Text);

        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            updateMovieDocument(dataViewAll.CurrentCell.Value.ToString());

        }

        private void createButton_Click(object sender, EventArgs e)
        {
            formNewMovie();

            txtID.Clear();
            txtRev.Clear();
            txtTitle.Clear();
            txtYr.Clear();
            txtDirector.Clear();
            txtProducer.Clear();
            txtComposer.Clear();
            txtRuntime.Clear();
            txtCompany.Clear();
            txtPrice.Clear();
            txtNoInStock.Clear();

        }




        private void dataViewAll_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            GetAndReadChosenDoc(dataViewAll.CurrentCell.Value.ToString());
        }



        private void dataSelectedMovie_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
