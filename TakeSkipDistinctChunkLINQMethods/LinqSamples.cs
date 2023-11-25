using LINQSamples;
using LINQSamples.Common;

namespace TakeSkipDistinctChunkLINQMethods
{
    public class LinqSamples : ViewModelBase
    {
        #region TakeQuery
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> TakeQuery()
        {
            var productList = GetProducts();

            // Take Query Syntax Here
            productList = (from prod in productList
                           orderby prod.Name
                           select prod).Take(5).ToList();

            return productList;
        }
        #endregion

        #region TakeMethod
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> TakeMethod()
        {
            var productList = GetProducts();

            // TakeWhile Method Syntax
            productList = productList.OrderBy(prod => prod.Name)
                            .TakeWhile(prod => prod.Cost <= 699.09M)
                            .ToList();

            return productList;
        }
        #endregion

        #region TakeRangeQuery
        /// <summary>
        /// Use Take() to select a specified number of items from a collection using the Range operator
        /// </summary>
        public List<Product> TakeRangeQuery()
        {
            var productList = GetProducts();

            // TakeRange Query Syntax Here
            productList = (from prod in productList
                           orderby prod.Name
                           select prod).Take(5..8).ToList();

            return productList;
        }
        #endregion

        #region TakeRangeMethod
        /// <summary>
        /// Use Take() to select a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> TakeRangeMethod()
        {
            var productList = GetProducts();

            // TakeRange Method Syntax Here
            productList = productList.OrderBy(prod => prod.Name).Take(5..8).ToList();

            return productList;
        }
        #endregion

        #region TakeWhileQuery
        /// <summary>
        /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> TakeWhileQuery()
        {
            var productList = GetProducts();

            // TakeWhile Query Syntax Here
            productList = (from prod in productList orderby prod.Name select prod)
                .TakeWhile(prod => prod.Name.StartsWith("A")).ToList();


            return productList;
        }
        #endregion

        #region TakeWhileMethod
        /// <summary>
        /// Use TakeWhile() to select a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> TakeWhileMethod()
        {
            var productList = GetProducts();

            // TakeWhile Method Syntax
            productList = productList.OrderBy(prod => prod.Name)
                            .TakeWhile(prod => prod.Name.StartsWith("A"))
                            .ToList();

            return productList;
        }
        #endregion

        #region SkipQuery
        /// <summary>
        /// Use Skip() to move past a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> SkipQuery()
        {
            var productList = GetProducts();

            // Skip Query Syntax Here
            productList = (from prod in productList
                    orderby prod.Name
                    select prod).Skip(30).ToList();

            return productList;
        }
        #endregion

        #region SkipMethod
        /// <summary>
        /// Use Skip() to move past a specified number of items from the beginning of a collection
        /// </summary>
        public List<Product> SkipMethod()
        {
            var productList = GetProducts();;

            // Skip Method Syntax Here
            productList = productList.OrderBy(prod => prod.Name).Skip(30).ToList();

            return productList;
        }
        #endregion

        #region SkipWhileQuery
        /// <summary>
        /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> SkipWhileQuery()
        {
            var productList = GetProducts();

            // SkipWhile Query Syntax Here
            productList = (from prod in productList
                    orderby prod.Name
                    select prod).SkipWhile(prod => prod.Name.StartsWith("A")).ToList();

            return productList;
        }
        #endregion

        #region SkipWhileMethod
        /// <summary>
        /// Use SkipWhile() to move past a specified number of items from the beginning of a collection based on a true condition
        /// </summary>
        public List<Product> SkipWhileMethod()
        {
            var productList = GetProducts();

            // SkipWhile Method Syntax
            productList = productList.OrderBy(prod => prod.Name)
                              .SkipWhile(prod => prod.Name.StartsWith("A"))
                              .ToList();

            return productList;
        }
        #endregion

        #region DistinctQuery
        /// <summary>
        /// The Distinct() operator finds all unique values within a collection.
        /// In this sample you put distinct product colors into another collection using LINQ
        /// </summary>
        public List<string> DistinctQuery()
        {
            var products = GetProducts();
            List<string> list;

            // Distinct Query Syntax Here
            list = (from prod in products
                    select prod.Color)
                    .Distinct().OrderBy(c => c).ToList();

            return list;
        }
        #endregion

        #region DistinctWhere
        /// <summary>
        /// The Distinct() operator finds all unique values within a collection.
        /// In this sample you put distinct product colors into another collection using LINQ
        /// </summary>
        public List<string> DistinctWhere()
        {
            var products = GetProducts();
            List<string> list;

            // Distinct Method Syntax Here
            list = products.Select(p => p.Color).Distinct().OrderBy(c => c).ToList();

            return list;
        }
        #endregion

        #region DistinctByQuery
        public List<Product> DistinctByQuery()
        {
            var productList = GetProducts();

            // DistinctBy Query Syntax Here
            productList = (from prod in productList
                    select prod)
                    .DistinctBy(prod => prod.Color)
                    .OrderBy(p => p.Color).ToList();

            return productList;
        }
        #endregion

        #region DistinctByMethod
        public List<Product> DistinctByMethod()
        {
            var productList = GetProducts();

            // DistinctBy Method Syntax Here
            productList = productList.DistinctBy(prod => prod.Color, default)
                            .OrderBy(p => p.Color).ToList();

            return productList;
        }
        #endregion

        #region ChunkQuery
        /// <summary>
        /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
        /// </summary>
        public List<Product[]> ChunkQuery()
        {
            var products = GetProducts();
            List<Product[]> list;

            // Chunk Query Syntax Here
            list = (from prod in products
                    select prod).Chunk(5).ToList();

            return list;
        }
        #endregion

        #region ChunkMethod
        /// <summary>
        /// Chunk() splits the elements of a larger list into a collection of arrays of a specified size where each element of the collection is an array of those items.
        /// </summary>
        public List<Product[]> ChunkMethod()
        {
            var products = GetProducts();
            List<Product[]> list;

            // Chunk Method Syntax Here
            list = products.Chunk(5).ToList();

            return list;
        }
        #endregion
    }
}
