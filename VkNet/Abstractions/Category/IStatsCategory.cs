﻿using System;
using System.Collections.ObjectModel;
using VkNet.Model;

namespace VkNet.Abstractions
{
	/// <summary>
	/// Методы для работы со статистикой.
	/// </summary>
	public interface IStatsCategory : IStatsCategoryAsync
	{
		/// <summary>
		/// Возвращает статистику сообщества или приложения.
		/// </summary>
		/// <param name="groupId"> Идентификатор сообщества. </param>
		/// <param name="dateFrom">
		/// Начальная дата выводимой статистики в формате
		/// YYYY-MM-DD.
		/// </param>
		/// <param name="dateTo"> Конечная дата выводимой статистики в формате YYYY-MM-DD. </param>
		/// <returns>
		/// Возвращает результат выполнения метода.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте https://vk.com/dev/stats.get
		/// </remarks>
		ReadOnlyCollection<StatsPeriod> GetByGroup(long groupId, DateTime dateFrom, DateTime? dateTo = null);

		/// <summary>
		/// Возвращает статистику сообщества или приложения.
		/// </summary>
		/// <param name="appId"> Идентификатор приложения. </param>
		/// <param name="dateFrom">
		/// Начальная дата выводимой статистики в формате
		/// YYYY-MM-DD.
		/// </param>
		/// <param name="dateTo"> Конечная дата выводимой статистики в формате YYYY-MM-DD. </param>
		/// <returns>
		/// Возвращает результат выполнения метода.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте https://vk.com/dev/stats.get
		/// </remarks>
		ReadOnlyCollection<StatsPeriod> GetByApp(long appId, DateTime dateFrom, DateTime? dateTo = null);

		/// <summary>
		/// Добавляет данные о текущем сеансе в статистику посещаемости приложения..
		/// </summary>
		/// <returns>
		/// В случае успешной обработки данных метод вернет <c> true </c>.
		/// </returns>
		/// <remarks>
		/// Страница документации ВКонтакте http://vk.com/dev/stats.trackVisitor
		/// </remarks>
		bool TrackVisitor();

		/// <summary>
		/// Возвращает статистику для записи на стене.
		/// </summary>
		/// <param name="ownerId">
		/// Идентификатор сообщества — владельца записи. Указывается
		/// со знаком «минус».
		/// </param>
		/// <param name="postId">
		/// Идентификатор записи. Обратите внимание — данные по статистике доступны только
		/// для 300
		/// последних(самых свежих) записей на стене сообщества.
		/// </param>
		/// <returns>
		/// Возвращает результат выполнения метода.
		/// </returns>
		/// <remarks>
		/// Необходимо входить в число руководителей этого сообщества.
		/// Страница документации ВКонтакте https://vk.com/dev/stats.getPostReach
		/// </remarks>
		PostReach GetPostReach(long ownerId, long postId);
	}
}