﻿using System.Data.SQLite;

namespace pds.Infrastructure.SQLite;

internal class SQLiteHelper
{
    internal const string ConnectionString = @"Data Source=pds.db;Version=3;";

    /// <summary>
    /// 全件取得
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <param name="CreateEntity"></param>
    /// <returns></returns>
    internal static IReadOnlyList<T> Query<T>(
        string sql,
        Func<SQLiteDataReader, T> CreateEntity)
    {
        return Query(sql, null, CreateEntity);
    }

    /// <summary>
    /// 全件取得
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    /// <param name="CreateEntity"></param>
    /// <returns></returns>
    internal static IReadOnlyList<T> Query<T>(
        string sql,
        SQLiteParameter[]? parameters, 
        Func<SQLiteDataReader, T> CreateEntity)
    {
        var result = new List<T>();

        using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
        using (var command = new SQLiteCommand(sql, connection))
        {
            connection.Open();

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }                

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    result.Add(CreateEntity(reader));
                }
            }
        }

        return result;
    }

    /// <summary>
    /// 1件のみ取得する nullEntiryはnullを返却するためのもの
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <param name="CreateEntity"></param>
    /// <param name="nullEntity"></param>
    /// <returns></returns>
    internal static T QuerySingle<T>(
        string sql,            
        Func<SQLiteDataReader, T> CreateEntity,
        T nullEntity)
    {
        return QuerySingle(sql, null, CreateEntity, nullEntity);
    }

    /// <summary>
    /// 1件のみ取得する nullEntiryはnullを返却するためのもの
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    /// <param name="CreateEntity"></param>        
    /// <param name="nullEntity"></param>
    /// <returns></returns>
    internal static T QuerySingle<T>(
        string sql,
        SQLiteParameter[]? parameters,
        Func<SQLiteDataReader, T> CreateEntity,            
        T nullEntity)
    {
        using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
        using (var command = new SQLiteCommand(sql, connection))
        {
            connection.Open();

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            using (var reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    return CreateEntity(reader);
                }
            }
        }

        return nullEntity;
    }

    /// <summary>
    /// 更新または追加を実行する（アップサート）
    /// </summary>
    /// <param name="insert"></param>
    /// <param name="update"></param>
    /// <param name="parameters"></param>
    internal static void Execute(
        string insert,
        string update,
        SQLiteParameter[] parameters)
    {
        using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
        using (var command = new SQLiteCommand(update, connection))
        {
            connection.Open();

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            // 件数が返却されない（実行できない）場合、インサート実行
            if (command.ExecuteNonQuery() < 1)
            {
                command.CommandText = insert;
                command.ExecuteNonQuery();
            }
        }
    }

    /// <summary>
    /// クエリを実行する
    /// </summary>
    /// <param name="sql"></param>
    /// <param name="parameters"></param>
    internal static void Execute(
        string sql,
        SQLiteParameter[] parameters)
    {
        using (var connection = new SQLiteConnection(SQLiteHelper.ConnectionString))
        using (var command = new SQLiteCommand(sql, connection))
        {
            connection.Open();

            if (parameters != null)
            {
                command.Parameters.AddRange(parameters);
            }

            command.ExecuteNonQuery();
        }
    }
}

