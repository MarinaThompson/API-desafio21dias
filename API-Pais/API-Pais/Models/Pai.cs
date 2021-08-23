using api_desafio21dias.Models;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;


namespace API_Pais.Models
{
    public partial class Pai
    {
        #region "Propriedades"
        [BsonId()]
        public ObjectId Id { get; set; }

        [BsonElement("nome")]
        [BsonRequired()]
        public string Nome { get; set; }

        [BsonElement("aluno_id")]
        [BsonRequired()]
        public int AlunoId { get; set; }

        [BsonElement("aluno")]
        [BsonRequired()]
        public Aluno Aluno { get; set; }

        #endregion
    }
}
