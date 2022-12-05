/* 
 * Copyright (C) 2022 Bushra KURT. All Rights Reserved.
 * 
 * SPDX-License-Identifier: GPL-2.0-only
 * 
 * Reference: https://github.com/ucoruh/ce103-hw3-2022-helper/tree/main/library-manager-dll
 *
 */

using System;
using System.Collections.Generic;

namespace ce103_hw3_lib
{
    public class Book
    {
        public const int LENGTH_ID = 4;
        public const int LENGTH_TITLE_MAX = 100;
        public const int LENGTH_DESC_MAX = 300;
        public const int LENGTH_AUTH_MAX = 100;
        public const int LENGTH_CTGRY_MAX = 100;
        public const int COUNT_AUTH_MAX = 5;
        public const int COUNT_CTGRY_MAX = 5;
        
        public const int BLOCK_SIZE_BOOK_DATA = LENGTH_ID +
                                                LENGTH_TITLE_MAX +
                                                LENGTH_DESC_MAX +
                                                (LENGTH_AUTH_MAX + COUNT_AUTH_MAX) +
                                                (LENGTH_CTGRY_MAX + COUNT_CTGRY_MAX);

        private int _id;
        private string _title;
        private string _desc;
        private List<string> _auth;
        private List<string> _ctgry;

        public int ID { get { return _id; } set { _id = value; } }
        public string Title { get { return _title; } set { _title = value; } }
        public string Desc { get { return _desc; } set { _desc = value; } }
        public List<string> Auth { get { return _auth; } set { _auth = value; } }
        public List<string> Ctgry { get { return _ctgry; } set { _ctgry = value; } }

        public Book()
        {
            _auth = new List<string>();
            _ctgry = new List<string>();
        }

        public static byte[] Book2Byte(Book book)
        {
            int point = 0;
            byte[] dataBuffer = new byte[BLOCK_SIZE_BOOK_DATA];

            byte[] idBytes = ConUtil.Int2ByteArray(book.ID);
            Array.Copy(idBytes, 0, dataBuffer, point, idBytes.Length);
            point += Book.LENGTH_ID;

            byte[] titleBytes = ConUtil.String2ByteArray(book.Title);
            Array.Copy(titleBytes, 0, dataBuffer, point, titleBytes.Length);
            point += Book.LENGTH_TITLE_MAX;

            byte[] descBytes = ConUtil.String2ByteArray(book.Desc);
            Array.Copy(descBytes, 0, dataBuffer, point, descBytes.Length);
            point += Book.LENGTH_DESC_MAX;

            byte[] authBytes = ConUtil.StrLst2ByteArray(book.Auth, Book.COUNT_AUTH_MAX, Book.LENGTH_AUTH_MAX);
            Array.Copy(authBytes, 0, dataBuffer, point, authBytes.Length);
            point += Book.COUNT_AUTH_MAX * Book.LENGTH_AUTH_MAX;

            byte[] ctgryBytes = ConUtil.StrLst2ByteArray(book.Ctgry, Book.COUNT_CTGRY_MAX, Book.LENGTH_CTGRY_MAX);
            Array.Copy(ctgryBytes, 0, dataBuffer, point, ctgryBytes.Length);
            point += Book.COUNT_CTGRY_MAX * Book.LENGTH_CTGRY_MAX;

            if (point != dataBuffer.Length)
            {
                throw new Exception("Point and Data Buffer sizes mismatch!");
            }

            return dataBuffer;
        }
    }
}
